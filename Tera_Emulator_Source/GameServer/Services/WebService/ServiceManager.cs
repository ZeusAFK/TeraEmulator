using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Tera.Services.WebService
{
    public class ServiceManager
    {
        private readonly List<ServiceHost> _serviceHosts = new List<ServiceHost>();
        private readonly Dictionary<Type, ServiceContractAttribute> _webServices = new Dictionary<Type, ServiceContractAttribute>();

        public ServiceManager()
        {
            this.LoadServices();
        }

        private void LoadServices()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(type => type.GetInterface("IWebService") != null))
            {
                object[] attributes = type.GetCustomAttributes(typeof(ServiceContractAttribute), true); // get the attributes of the packet.
                if (attributes.Length == 0) return;

                _webServices.Add(type, (ServiceContractAttribute)attributes[0]);
            }
        }

        public void Run()
        {
            foreach (var pair in this._webServices)
            {
                var uri = new Uri(string.Format("{0}/{1}", "http://localhost:9000", pair.Value.Name));
                var serviceHost = new ServiceHost(pair.Key, uri);

                serviceHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
                var debugBehavior = (ServiceDebugBehavior)serviceHost.Description.Behaviors[typeof(ServiceDebugBehavior)];
                debugBehavior.IncludeExceptionDetailInFaults = true;

                serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "Mex");
                serviceHost.AddServiceEndpoint(pair.Key, new BasicHttpBinding(), "");

                serviceHost.Open();
                this._serviceHosts.Add(serviceHost);
            }

            Log.Info("Loaded web-services manager with {0} services..", this._webServices.Count);
        }
    }
}
