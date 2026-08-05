/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     constructor(val = 0, left = null, right = null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    /**
     * @param {TreeNode} root
     * @return {number}
     */
    maxDepth(root: TreeNode | null): number {
        if (root === null) return 0;

        let stack: { node, depth}[] = [];
        stack.push({ node: root, depth: 1 });

        let max_depth = 0;

        while (stack.length > 0) {
            let current = stack.pop()!; 
            let node = current.node;
            let depth = current.depth;

            // Met à jour la profondeur maximale trouvée jusqu'à présent
            max_depth = Math.max(max_depth, depth);

            // Ajoute les enfants à la pile en incrémentant leur profondeur
            if (node.right !== null) {
                stack.push({ node: node.right, depth: depth + 1 });
            }
            if (node.left !== null) {
                stack.push({ node: node.left, depth: depth + 1 });
            }
        }
        
        return max_depth;

    }
}
