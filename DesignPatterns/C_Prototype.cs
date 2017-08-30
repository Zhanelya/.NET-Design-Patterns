using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class C_Prototype
    {
        private string _id;
        private string _name;
        private static string _age; //will be shared between the original and cloned object, only reference to it will be copied
        public C_Prototype(string id)
        {
            this._id = id;
        }
        public string Id
        {
            get { return _id; }
        }
        public abstract C_Prototype Clone();
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
    class ConcretePrototype1 : C_Prototype
    {
        public ConcretePrototype1(string id)
          : base(id)
        {
        }
        public override C_Prototype Clone() //returns a shallow copy (creates a new object, copies nonstatic fields to the new object by value, copies static fields by reference)
        {
            return (C_Prototype)this.MemberwiseClone();
        }
    }
    class ConcretePrototype2 : C_Prototype
    {
        public ConcretePrototype2(string id)
          : base(id)
        {
        }
        public override C_Prototype Clone() //returns a shallow copy
        {
            return (C_Prototype)this.MemberwiseClone();
        }
    }
}
