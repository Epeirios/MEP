using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MEP
{
    class Weapon
    {
        private int _ammo { get; set; }
        private int _maxAmmo { get; set; }

        private object _scope { get; set; }

        public Weapon(int maxAmmo)
        {
            this._maxAmmo = _maxAmmo;
            this._ammo = maxAmmo;
        }

        public void Shoot()
        {
            _ammo -= 1;
            if (_ammo == 0) { Reload(); }
        }

        public void Reload()
        {
            _ammo = _maxAmmo;
        }


    }

    static class XMLparser
    {
        static IEnumerable<XElement> SimpleStreamAxis(string inputUrl,
                                              string elementName)
        {
            using (XmlReader reader = XmlReader.Create(inputUrl))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == elementName)
                        {
                            XElement el = XNode.ReadFrom(reader) as XElement;
                            if (el != null)
                            {
                                yield return el;
                            }
                        }
                    }
                }
            }
        }
    }

}
