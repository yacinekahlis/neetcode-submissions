/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Dictionary<Node, Node> map = new Dictionary<Node, Node>();


    public Node CloneGraph(Node node) {
        if (node == null) return null;

        // 1. si ce node est déjà cloné, retourne son clone existant
        //    (c'est ça qui casse le cycle)
        if (map.ContainsKey(node)) {
            return map[node]; /* ??? le clone déjà enregistré */;
        }

        // 2. crée le clone de CE node (juste la valeur, voisins vides pour l'instant)
        var clone = new Node(node.val);

        // 3. enregistre-le AVANT de récurser (crucial : sinon le cycle te rattrape)
        map[node] = clone;

        // 4. pour chaque voisin de l'original, clone-le récursivement
        //    et ajoute le résultat aux voisins du clone
        foreach (var neighbor in node.neighbors) {
            clone.neighbors.Add(CloneGraph(neighbor)/* ??? le clone du voisin */);
        }

        // 5. retourne le clone complété
        return clone;

    }
}
