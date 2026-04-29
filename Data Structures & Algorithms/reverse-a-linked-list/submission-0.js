/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @return {ListNode}
     */
    reverseList(head) {
        //pointeurs
        let prev = null; //yen a pas avant
        let curr = head; //la tete donc le premier

        //boucle tant quon est pas à la fin
        while (curr!=null){
            //sauv le prochain
            let next = curr.next;

            //inverser le pointeur
            curr.next = prev;

            //avance le precedent
            prev = curr;

            //avance l'actuel
            curr = next;
        }
        
        //return le precedent
        return prev;
    }
}
