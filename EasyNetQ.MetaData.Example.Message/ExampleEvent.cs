﻿namespace EasyNetQ.MetaData.Example.Message {
    using System;
    using System.Runtime.Serialization;

    public class ExampleEvent {
        public String MessageContent { get; set; }

        [MessageHeader("my_custom_header"), IgnoreDataMember]
        public String CustomHeaderValue { get; set; }

        [MessageProperty(Property.ContentType), IgnoreDataMember]
        public String ContentType { get; set; }

        [MessageProperty(Property.ContentEncoding), IgnoreDataMember]
        public String ContentEncoding { get; set; }

        [MessageProperty(Property.Timestamp), IgnoreDataMember]
        public DateTime Timestamp { get; set; }
    }
}