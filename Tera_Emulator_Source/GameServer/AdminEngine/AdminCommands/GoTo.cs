using System;
using Communication;
using Data.Enums;
using Data.Interfaces;
using Data.Structures.Player;
using Data.Structures.World;
using Network.Server;
using Tera.Services;
using Utils;

namespace Tera.AdminEngine.AdminCommands
{
    internal class GoTo : ACommand
    {
        public override void Process(IConnection connection, string msg)
        {
            try
            {
                if (msg.Length == 0)
                {
                    new SpChatMessage("Maps:", ChatType.System).Send(connection);
                    foreach (var map in MapService.Maps)
                        new SpChatMessage("" + map.Key, ChatType.System).Send(connection);
                    return;
                }

                Player player = connection.Player;

                string[] options = msg.Split(' ');

                switch (options[0].ToLower())
                {
                    case "pos":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = player.Position.Heading,
                                                                     MapId = player.Position.MapId,
                                                                     X = float.Parse(options[1]),
                                                                     Y = float.Parse(options[2]),
                                                                     Z = float.Parse(options[3])
                                                                 });
                        break;

                    case "islandofdawn":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 32767,
                                                                     MapId = 13,
                                                                     X = 93492,
                                                                     Y = -88216,
                                                                     Z = -4523
                                                                 });
                        break;
                    case "velica":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 22242,
                                                                     MapId = 1,
                                                                     X = 1600.987F,
                                                                     Y = 3041.877F,
                                                                     Z = 1743.736F
                                                                 });
                        break;

                    case "loc3":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 28242,
                                                                     MapId = 7001,
                                                                     X = 91217.6F,
                                                                     Y = -2416.63F,
                                                                     Z = 683.142F
                                                                 });
                        break;

                    case "prolog":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 180,
                                                                     MapId = 9015,
                                                                     X = BitConverter.ToSingle("00E0C745".ToBytes(), 0),
                                                                     Y = BitConverter.ToSingle("003E5BC7".ToBytes(), 0),
                                                                     Z = BitConverter.ToSingle("00001442".ToBytes(), 0)
                                                                 });
                        break;

                    case "prolog_dang":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 0,
                                                                     MapId = 9016,
                                                                     X = BitConverter.ToSingle("31802FC7".ToBytes(), 0),
                                                                     Y = BitConverter.ToSingle("341C6BC7".ToBytes(), 0),
                                                                     Z = BitConverter.ToSingle("BDD8C1C5".ToBytes(), 0)
                                                                 });
                        break;

                    case "all":
                        //Global.PlayerService.TeleportPlayer(PlayerService.GetPlayerByName(options[1]), player.Position);
                        break;
                    case "optional":
                        Global.TeleportService.ForceTeleport(player,
                                                             new WorldPosition
                                                                 {
                                                                     Heading = 32767,
                                                                     MapId = Convert.ToInt32(options[1]),
                                                                     X = Convert.ToInt32(options[2]),
                                                                     Y = Convert.ToInt32(options[3]),
                                                                     Z = Convert.ToInt32(options[4])
                                                                 });
                        break;

                    case "dang1":
                        Global.TeleportService.ForceTeleport(connection.Player, new WorldPosition
                                                                                    {
                                                                                        Heading = -32651,
                                                                                        MapId = 9036,
                                                                                        X =
                                                                                            BitConverter.ToSingle(
                                                                                                "00438B47".ToBytes(), 0),
                                                                                        Y =
                                                                                            BitConverter.ToSingle(
                                                                                                "004027C6".ToBytes(), 0),
                                                                                        Z =
                                                                                            BitConverter.ToSingle(
                                                                                                "00002DC3".ToBytes(), 0)
                                                                                    });
                        break;
                    default:
                        int mapId = int.Parse(msg);
                        Global.TeleportService.ForceTeleport(connection.Player, MapService.Maps[mapId][0].Npcs[0].Position);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.ErrorException("AdminEngine: Speed:", ex);
            }
        }
    }
}
