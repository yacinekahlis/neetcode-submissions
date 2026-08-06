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
     * @return {number[][]}
     */
    levelOrder(root: TreeNode | null): number[][] {
        //cest juste de faire un bfs et à chaq niveau on ajoute la liste des nodes
        if (root === null) return [];
        
        let nodesForEachLevel = [[root.val]];
        let queue = [root];

        while(queue.length>0){
            let size = queue.length;
            let nodesInLevel = [];

            for (let i = 0; i<size; i++){
                let currentNode = queue.shift();

                if(currentNode.left !== null){
                    queue.push(currentNode.left);
                    nodesInLevel.push(currentNode.left.val);
                    }
                if(currentNode.right !== null) {
                    queue.push(currentNode.right);
                    nodesInLevel.push(currentNode.right.val);
                    }
            }
            
            if(nodesInLevel.length > 0) nodesForEachLevel.push(nodesInLevel);
            
        }

            console.log(nodesForEachLevel)

        
        return nodesForEachLevel;
    }
}
