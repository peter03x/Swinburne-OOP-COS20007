using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    internal class IdentifiableObject
    {
        private List<string> _identifiers;
        public  IdentifiableObject(string[] idents)
        {
            _identifiers.AddRange(idents);
        }
        public bool AreYou(string id)
        {
            foreach(string c in _identifiers) 
            { 
                if (c == id) return true;
            }
            return false;
        }
        public string FirstId
        { 
            get
            {
                if (_identifiers == null) return ""; 
                else return _identifiers.First();
            }
        }
        public void AddIdentifier(string id)
        {
            int i = 0;
            foreach (string c in _identifiers)
            {
                ++i;
                if (c == id)
                {
                    _identifiers.Remove(c);
                    _identifiers.Insert(i, id.ToLower());
                    break;
                }
            }
            i = 0;
        }
    }
}
