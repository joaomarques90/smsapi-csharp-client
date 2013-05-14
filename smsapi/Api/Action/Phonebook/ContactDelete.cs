﻿using System.Collections.Specialized;
using System.IO;
using System.Runtime.Serialization.Json;

namespace SMSApi.Api.Action
{
    public class PhonebookContactDelete : Base<SMSApi.Api.Response.Base>
    {
        public PhonebookContactDelete() : base() { }

        protected override string Uri() { return "phonebook.do"; }

        protected string number;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("delete_contact", number);

            return collection;
        }

        public PhonebookContactDelete Number(string number)
        {
            this.number = number;
            return this;
        }
    }
}