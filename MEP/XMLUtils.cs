using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MEP
{
    static class XMLUtils
    {
        public static int GetNodeTypeCount(XmlNode node, XmlNodeType nodeType)
        {
            // Recursively loop through the given node and return 
            // the number of occurences of a specific nodeType.
            int i = 0;

            if (node.NodeType == nodeType)
                i = i + 1;

            if (node.HasChildNodes)
                foreach (XmlNode cNode in node.ChildNodes)
                    i = i + GetNodeTypeCount(cNode, nodeType);

            return i;
        }

        public static XmlDocument OpenXmlDocument (string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            return doc;
        }

        //[STAThread]
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        // Create an Xml document instance and load XML data.
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load("C:\\Q317664.xml");

        //        // 1. Select all the Book titles by using an XPath query.
        //        XmlNodeList nodeList = doc.SelectNodes("//Book/Title");
        //        XmlNode node;
        //        Console.WriteLine("{0}", "TITLES LIST: ");
        //        foreach (XmlNode nd in nodeList)
        //            Console.WriteLine("{0}", nd.InnerText);

        //        // 2. Read the XmlDeclartion values.
        //        XmlDeclaration decl = (XmlDeclaration)doc.FirstChild;
        //        Console.WriteLine("\n{0}", "XML DECLARTION:");
        //        Console.WriteLine("{0}", "Version    " + "= " + decl.Version);
        //        Console.WriteLine("{0}", "Encoding   " + "= " + decl.Encoding);
        //        Console.WriteLine("{0}", "Standalone " + "= " + decl.Standalone);

        //        // 3. Move to the first node of DOM and get all of its attributes.
        //        XmlElement root = doc.DocumentElement;
        //        node = root.FirstChild;
        //        Console.WriteLine("\n{0}", "ATTRIBUTES OF THE FIRST CHILD:");
        //        foreach (XmlAttribute attr in node.Attributes)
        //            Console.WriteLine("{0}", attr.Name + " = " + attr.InnerText);

        //        // 4. Navigate to the child nodes of the first Book node.
        //        Console.WriteLine("\n{0}", "FIRST NODE'S CHILDREN:");
        //        if (node.HasChildNodes)
        //            foreach (XmlNode cNode in node.ChildNodes)
        //                Console.WriteLine("{0}", cNode.OuterXml);

        //        // 5. Navigate to the next sibling of the first Book node.
        //        node = node.NextSibling;
        //        Console.WriteLine("\n{0}", "NEXT SIBLING:");
        //        if (node != null)
        //            Console.WriteLine("{0}", node.OuterXml);

        //        // 6. Get the parent node details of the current node.
        //        Console.WriteLine("\n{0}", "PARENT NODE NAME = " + node.ParentNode.Name);
        //        Console.WriteLine("{0}", "PARENT NODE HAS " + node.ParentNode.ChildNodes.Count + " CHILD NODES");
        //        Console.WriteLine("{0}", "PARENT NODE'S NAMESPACE URI = " + node.ParentNode.NamespaceURI);

        //        // 7. Count the number of Comment nodes in the document.
        //        // You could search for other types in the same way.
        //        int commentNodes = GetNodeTypeCount(doc.DocumentElement, XmlNodeType.Comment);
        //        Console.WriteLine("\n{0}\n", "NUMBER OF COMMENT NODES IN THE DOC = " + commentNodes);
        //        Console.ReadLine();
        //    }
        //    catch (XmlException xmlEx)        // Handle the XML Exceptions here.         
        //    {
        //        Console.WriteLine("{0}", xmlEx.Message);
        //    }
        //    catch (Exception ex)              // Handle the Generic Exceptions here.
        //    {
        //        Console.WriteLine("{0}", ex.Message);
        //    }
        //}
    }
}
