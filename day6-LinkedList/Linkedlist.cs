namespace day6_LinkedList
{
    public class Linkedlist
    {

     Node head ;

        public void reverseInsert(int data){
            Node newnode = new Node(data);

            if(head == null){
                head = newnode;
            }else{
                Node temp = head;
                head = newnode;
                head.next = temp;  
            }
        }
       
        public void Display(){
            Node current = head;
            while(current != null){
                System.Console.Write(current.data+ "->");
                current = current.next;
            }
        }
    }
}