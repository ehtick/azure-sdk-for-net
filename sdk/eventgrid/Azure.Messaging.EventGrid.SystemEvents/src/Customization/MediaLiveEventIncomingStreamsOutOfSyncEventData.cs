// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Incoming streams out of sync event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventIncomingStreamsOutOfSync event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaLiveEventIncomingStreamsOutOfSyncEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaLiveEventIncomingStreamsOutOfSyncEventData"/>. </summary>
        internal MediaLiveEventIncomingStreamsOutOfSyncEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventIncomingStreamsOutOfSyncEventData"/>. </summary>
        /// <param name="minLastTimestamp"> Gets the minimum last timestamp received. </param>
        /// <param name="typeOfStreamWithMinLastTimestamp"> Gets the type of stream with minimum last timestamp. </param>
        /// <param name="maxLastTimestamp"> Gets the maximum timestamp among all the tracks (audio or video). </param>
        /// <param name="typeOfStreamWithMaxLastTimestamp"> Gets the type of stream with maximum last timestamp. </param>
        /// <param name="timescaleOfMinLastTimestamp"> Gets the timescale in which "MinLastTimestamp" is represented. </param>
        /// <param name="timescaleOfMaxLastTimestamp"> Gets the timescale in which "MaxLastTimestamp" is represented. </param>
        internal MediaLiveEventIncomingStreamsOutOfSyncEventData(string minLastTimestamp, string typeOfStreamWithMinLastTimestamp, string maxLastTimestamp, string typeOfStreamWithMaxLastTimestamp, string timescaleOfMinLastTimestamp, string timescaleOfMaxLastTimestamp)
        {
            MinLastTimestamp = minLastTimestamp;
            TypeOfStreamWithMinLastTimestamp = typeOfStreamWithMinLastTimestamp;
            MaxLastTimestamp = maxLastTimestamp;
            TypeOfStreamWithMaxLastTimestamp = typeOfStreamWithMaxLastTimestamp;
            TimescaleOfMinLastTimestamp = timescaleOfMinLastTimestamp;
            TimescaleOfMaxLastTimestamp = timescaleOfMaxLastTimestamp;
        }

        /// <summary> Gets the minimum last timestamp received. </summary>
        public string MinLastTimestamp { get; }
        /// <summary> Gets the type of stream with minimum last timestamp. </summary>
        public string TypeOfStreamWithMinLastTimestamp { get; }
        /// <summary> Gets the maximum timestamp among all the tracks (audio or video). </summary>
        public string MaxLastTimestamp { get; }
        /// <summary> Gets the type of stream with maximum last timestamp. </summary>
        public string TypeOfStreamWithMaxLastTimestamp { get; }
        /// <summary> Gets the timescale in which "MinLastTimestamp" is represented. </summary>
        public string TimescaleOfMinLastTimestamp { get; }
        /// <summary> Gets the timescale in which "MaxLastTimestamp" is represented. </summary>
        public string TimescaleOfMaxLastTimestamp { get; }
    }
}
