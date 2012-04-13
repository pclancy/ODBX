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

    public class Difference
    {
        public string DisplayValue { get; set; }
        public string InternalState { get; set; }
        public bool IsDifferent { get; set; }
        public bool IsInSource { get; set; }
        public bool IsInTarget { get; set; }
        public Action Action { get; set; }
    }


    public class Model
    {
        private readonly List<ModelObject> _objects = new List<ModelObject>();

        public IList<ModelObject> Objects
        {
            get { return _objects; }
        }

        public void Add(string type, string fullName, Guid guid, int id, Difference difference)
        {
            _objects.Add(new ModelObject

                             {
                                 Type = type,
                                 Fullname = fullName,
                                 Guid = guid,
                                 Id = id,
                                 Difference = difference
                             }
                );
        }
    }

    public class ModelObject
    {
        public string Fullname { get; set; }
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public Difference Difference { get; set; }
        public string Type { get; set; }
    }
}