// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Model.cs
//   
//  

using System;
using System.Collections.Generic;

namespace ODBX.Driver
{
    public enum Action
    {
        Unknown,
        Drop,
        Rebuild,
        Update,
        Create,
        None,
        Alter
    }

    public class Model
    {
        private readonly List<ModelObject> _objects = new List<ModelObject>();

        public IList<ModelObject> Objects
        {
            get { return _objects; }
        }

        public void Add(string type, string fullName, Guid guid, int id, Action action)
        {
            _objects.Add(new ModelObject

                             {
                                 Type = type,
                                 Fullname = fullName,
                                 Guid = guid,
                                 Id = id,
                                 Action = action
                             }
                );
        }
    }

    public class ModelObject
    {
        public string Fullname { get; set; }
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public Action Action { get; set; }
        public string Type { get; set; }
    }
}