// Sample.Plugin ~ EventSubscriber.cs
// EventSubscriber.cs
//
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using FFXIVAPP.IPluginInterface.Events;
using ffxivmc.Plugin.Utilities;
using FFXIVAPP.Common.Utilities;
using NLog;
using ffxivmc.Plugin.MarketData;

namespace ffxivmc.Plugin
{
    public static class EventSubscriber
    {
        public static void Subscribe()
        {
            Logging.Log(LogManager.GetCurrentClassLogger(), "subscribing");



            Plugin.PHost.NewConstantsEntity += OnNewConstantsEntity;
            Plugin.PHost.NewChatLogEntry += OnNewChatLogEntry;
            Plugin.PHost.NewMonsterEntriesAdded += OnNewMonsterEntriesAdded;
            Plugin.PHost.NewMonsterEntries += OnNewMonsterEntries;
            Plugin.PHost.NewMonsterEntriesRemoved += OnNewMonsterEntriesRemoved;
            Plugin.PHost.NewNPCEntriesAdded += OnNewNPCEntriesAdded;
            Plugin.PHost.NewNPCEntries += OnNewNPCEntries;
            Plugin.PHost.NewNPCEntriesRemoved += OnNewNPCEntriesRemoved;
            Plugin.PHost.NewPCEntriesAdded += OnNewPCEntriesAdded;
            Plugin.PHost.NewPCEntries += OnNewPCEntries;
            Plugin.PHost.NewPCEntriesRemoved += OnNewPCEntriesRemoved;
            Plugin.PHost.NewPlayerEntity += OnNewPlayerEntity;
            Plugin.PHost.NewTargetEntity += OnNewTargetEntity;
            Plugin.PHost.NewPartyEntriesAdded += OnNewPartyEntriesAdded;
            Plugin.PHost.NewPartyEntries += OnNewPartyEntries;
            Plugin.PHost.NewPartyEntriesRemoved += OnNewPartyEntriesRemoved;
            Plugin.PHost.NewInventoryEntries += OnNewInventoryEntries;
            Plugin.PHost.NewNetworkPacket += OnNewNetworkPacket;
        }

        public static void UnSubscribe()
        {
            Plugin.PHost.NewConstantsEntity -= OnNewConstantsEntity;
            Plugin.PHost.NewChatLogEntry -= OnNewChatLogEntry;
            Plugin.PHost.NewMonsterEntriesAdded -= OnNewMonsterEntriesAdded;
            Plugin.PHost.NewMonsterEntries -= OnNewMonsterEntries;
            Plugin.PHost.NewMonsterEntriesRemoved -= OnNewMonsterEntriesRemoved;
            Plugin.PHost.NewNPCEntriesAdded -= OnNewNPCEntriesAdded;
            Plugin.PHost.NewNPCEntries -= OnNewNPCEntries;
            Plugin.PHost.NewNPCEntriesRemoved -= OnNewNPCEntriesRemoved;
            Plugin.PHost.NewPCEntriesAdded -= OnNewPCEntriesAdded;
            Plugin.PHost.NewPCEntries -= OnNewPCEntries;
            Plugin.PHost.NewPCEntriesRemoved -= OnNewPCEntriesRemoved;
            Plugin.PHost.NewPlayerEntity -= OnNewPlayerEntity;
            Plugin.PHost.NewTargetEntity -= OnNewTargetEntity;
            Plugin.PHost.NewPartyEntriesAdded -= OnNewPartyEntriesAdded;
            Plugin.PHost.NewPartyEntries -= OnNewPartyEntries;
            Plugin.PHost.NewPartyEntriesRemoved -= OnNewPartyEntriesRemoved;
            Plugin.PHost.NewInventoryEntries -= OnNewInventoryEntries;
            Plugin.PHost.NewNetworkPacket -= OnNewNetworkPacket;
        }

        #region Subscriptions

        private static void OnNewConstantsEntity(object sender, ConstantsEntityEvent constantsEntityEvent)
        {
            // delegate event from constants, not required to subsribe, but recommended as it gives you app settings
            if (sender == null)
            {
                return;
            }
            var constantsEntity = constantsEntityEvent.ConstantsEntity;
            Constants.AutoTranslate = constantsEntity.AutoTranslate;
            Constants.ChatCodes = constantsEntity.ChatCodes;
            Constants.Actions = constantsEntity.Actions;
            Constants.Colors = constantsEntity.Colors;
            Constants.CultureInfo = constantsEntity.CultureInfo;
            Constants.CharacterName = constantsEntity.CharacterName;
            Constants.ServerName = constantsEntity.ServerName;
            Constants.GameLanguage = constantsEntity.GameLanguage;
            Constants.EnableHelpLabels = constantsEntity.EnableHelpLabels;
            Constants.Theme = constantsEntity.Theme;
            PluginViewModel.Instance.EnableHelpLabels = Constants.EnableHelpLabels;
        }

        private static void OnNewChatLogEntry(object sender, ChatLogEntryEvent chatLogEntryEvent)
        {
            // delegate event from chat log, not required to subsribe
            // this updates 100 times a second and only sends a line when it gets a new one
            if (sender == null)
            {
                return;
            }
            var chatLogEntry = chatLogEntryEvent.ChatLogEntry;
        }

        private static void OnNewMonsterEntriesAdded(object sender, ActorEntitiesAddedEvent actorEntitiesAddedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is newly placed in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesAddedEvent.Keys;
        }

        private static void OnNewMonsterEntries(object sender, ActorEntitiesEvent actorEntitiesEvent)
        {
            // delegate event from monster entities from ram, not required to subsribe
            // this is sent once, and by reference so you only need to use it after
            if (sender == null)
            {
                return;
            }
            var monsterEntities = actorEntitiesEvent.ActorEntities;
        }

        private static void OnNewMonsterEntriesRemoved(object sender, ActorEntitiesRemovedEvent actorEntitiesRemovedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is no longer in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesRemovedEvent.Keys;
        }

        private static void OnNewNPCEntriesAdded(object sender, ActorEntitiesAddedEvent actorEntitiesAddedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is newly placed in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesAddedEvent.Keys;
        }

        private static void OnNewNPCEntries(object sender, ActorEntitiesEvent actorEntitiesEvent)
        {
            // delegate event from npc entities from ram, not required to subsribe
            // this is sent once, and by reference so you only need to use it after
            if (sender == null)
            {
                return;
            }
            var npcEntities = actorEntitiesEvent.ActorEntities;
        }

        private static void OnNewNPCEntriesRemoved(object sender, ActorEntitiesRemovedEvent actorEntitiesRemovedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is no longer in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesRemovedEvent.Keys;
        }

        private static void OnNewPCEntriesAdded(object sender, ActorEntitiesAddedEvent actorEntitiesAddedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is newly placed in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesAddedEvent.Keys;
        }

        private static void OnNewPCEntries(object sender, ActorEntitiesEvent actorEntitiesEvent)
        {
            // delegate event from pc entities from ram, not required to subsribe
            // this is sent once, and by reference so you only need to use it after
            if (sender == null)
            {
                return;
            }
            var pcEntities = actorEntitiesEvent.ActorEntities;
        }

        private static void OnNewPCEntriesRemoved(object sender, ActorEntitiesRemovedEvent actorEntitiesRemovedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is no longer in ram
            if (sender == null)
            {
                return;
            }
            var keys = actorEntitiesRemovedEvent.Keys;
        }

        private static void OnNewPlayerEntity(object sender, PlayerEntityEvent playerEntityEvent)
        {
            // delegate event from player info from ram, not required to subsribe
            // this is for YOU and includes all your stats and your agro list with hate values as %
            // this updates 10x a second and only sends data when the newly read data is differen than what was previously sent
            if (sender == null)
            {
                return;
            }
            var playerEntity = playerEntityEvent.PlayerEntity;
        }

        private static void OnNewTargetEntity(object sender, TargetEntityEvent targetEntityEvent)
        {
            // delegate event from target info from ram, not required to subsribe
            // this includes the full entities for current, previous, mouseover, focus targets (if 0+ are found)
            // it also includes a list of upto 16 targets that currently have hate on the currently targeted monster
            // these hate values are realtime and change based on the action used
            // this updates 10x a second and only sends data when the newly read data is differen than what was previously sent
            if (sender == null)
            {
                return;
            }
            var targetEntity = targetEntityEvent.TargetEntity;
        }

        private static void OnNewPartyEntriesAdded(object sender, PartyEntitiesAddedEvent partyEntitiesAddedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is newly placed in ram
            if (sender == null)
            {
                return;
            }
            var keys = partyEntitiesAddedEvent.Keys;
        }

        private static void OnNewPartyEntries(object sender, PartyEntitiesEvent partyEntitiesEvent)
        {
            // delegate event from party entities from ram, not required to subsribe
            // this is sent once, and by reference so you only need to use it after
            if (sender == null)
            {
                return;
            }
            var partyEntities = partyEntitiesEvent.PartyEntities;
        }

        private static void OnNewPartyEntriesRemoved(object sender, PartyEntitiesRemovedEvent partyEntitiesRemovedEvent)
        {
            // delegate event that is sent everytime ram is read (10x a second) and if any entity is no longer in ram
            if (sender == null)
            {
                return;
            }
            var keys = partyEntitiesRemovedEvent.Keys;
        }

        private static void OnNewInventoryEntries(object sender, InventoryEntitiesEvent inventoryEntitiesEvent)
        {
            // delegate event from inventory info worker that will give all inventory items across any and all bags except retainers
            if (sender == null)
            {
                return;
            }
            var inventoryEntities = inventoryEntitiesEvent.InventoryEntities;
        }

        private static void OnNewNetworkPacket(object sender, NetworkPacketEvent networkPacketEvent)
        {

            // delegate event from network worker, this will be all incoming packets for the game
            if (sender == null)
            {
                return;
            }
            var networkPacket = networkPacketEvent.Packet;
            // networkPacket.Key is unique for each type of packet
            // you will have to implement your own parsing of the newPacket.Message/Buffer after this
            // packets are already decrypted

            //BitConverter.ToString(networkPacket.Buffer)

            //LogPublisher.WriteLine("Packet picked up");
            //Logging.Log(LogManager.GetCurrentClassLogger(), debug_output);


                switch (networkPacket.Key)
            {
                case 17563668:
                    //?? market related
                    break;
                case 17039380:
                    //?? market related
                    break;
                case 17367060:
                    //?? market related
                    break;

                case 17104916:
                    LogPublisher.WriteLine("Parsing market packet");
                    if (networkPacket.MessageSize != 1160)
                    {
                        LogPublisher.WriteLine("invalid order list, wrong size. expected 1160, got " + networkPacket.MessageSize);
                        break;
                    }
                    //list of market orders
                    try {
                        MarketParser.ParseOrderList(networkPacket.Buffer);
                    } catch (Exception)
                    {
                        LogPublisher.WriteLine("exception encountered with parsing");
                    }

                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
