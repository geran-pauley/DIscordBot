﻿using Discord;
using System;

namespace Victoria
{
    /// <summary>
    /// Configuration follows application.yml. Values should match up in configuration and application.yml.
    /// </summary>
    public sealed class Configuration
    {
        /// <summary>
        /// Lavalink host.
        /// </summary>
        public string Host { get; set; } = "127.0.0.1";

        /// <summary>
        /// Lavalink port.
        /// </summary>
        public int Port { get; set; } = 2333;

        /// <summary>
        /// Lavalink password.
        /// </summary>
        public string Password { get; set; } = "franklinhood";

        /// <summary>
        /// Websocket buffer size.
        /// </summary>
        public ushort? BufferSize { get; set; } = 512;

        /// <summary>
        /// Self deaf client.
        /// </summary>
        public bool SelfDeaf { get; set; } = true;

        /// <summary>
        /// Logging severity.
        /// </summary>
        public LogSeverity LogSeverity { get; set; } = LogSeverity.Info;

        /// <summary>
        /// Websocket reconnect attempts.
        /// </summary>
        public int ReconnectAttempts { get; set; } = 10;

        /// <summary>
        /// Websocket reconnect delay.
        /// </summary>
        public TimeSpan ReconnectInterval { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Whether to automatically disconnect after everyone leaves.
        /// </summary>
        public bool AutoDisconnect { get; set; }

        /// <summary>
        /// Should players be preserved if Victoria loses connection?
        /// </summary>
        public bool PreservePlayers { get; set; } = false;

        /// <summary>
        /// Timeout before <see cref="AutoDisconnect"/>.
        /// </summary>
        public TimeSpan InactivityTimeout { get; set; } = TimeSpan.FromMinutes(3);

        /// <summary>
        /// The default volume players should have when joining a voice chat
        /// </summary>
        public int DefaultVolume { get; set; } = 100;

        internal int Shards { get; set; }
        internal ulong UserId { get; set; }
        internal static LogSeverity InternalSeverity { get; set; }

        public Configuration SetInternals(ulong userId, int shards)
        {
            UserId = userId;
            Shards = shards;
            InternalSeverity = LogSeverity;
            return this;
        }
    }
}