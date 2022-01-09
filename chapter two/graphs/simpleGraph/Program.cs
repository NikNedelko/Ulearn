using System;
using System.Collections.Generic;
using System.Collections;
namespace simpleGraph
{
    public class Node
    {
        private readonly List<Node> incidentNodes = new List<Node>();
        public readonly int Number;
        public Node (int number){
            Number=number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
        public IEnumerable<Node> IncidentNodes{
            get{
                foreach(var node in IncidentNodes)
                yield return node;
            }
        }
        public void Connect(Node anotherNode){
            incidentNodes.Add(anotherNode);
            anotherNode.incidentNodes.Add(this);
        }
    }
    public class Graph
    {
        public readonly List<Node> Nodes = new List<Node>();
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var graph = new Graph();
            var v1 = new Node(0);
            var v2 = new Node(1);
            v1.Connect(v2);
            graph.Nodes.Add(v1);
            graph.Nodes.Add(v2);
        }

    }
}
