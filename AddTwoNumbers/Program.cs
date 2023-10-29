// See https://aka.ms/new-console-template for more information

using AddTwoNumbers;

Console.WriteLine("Hello, World!");
ListNode l1 = MakeListNodeFromArray(new int[]{9,9,9,9,9,9,9});
ListNode l2 = MakeListNodeFromArray(new int[]{9,9,9,9});

ListNode answer = AddTwoNumbers(l1, l2);
Console.WriteLine("Done!");
string str = "";

for (ListNode i = answer; i != null; i = i.next)
{
    str += i.val.ToString();
}

Console.WriteLine("the answer is: " + str);


ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode currentL1Node = l1;
    ListNode currentL2Node = l2;
    ListNode result = null;
    ListNode currentResultNode = null;
    int carry = 0;

    bool goOn = true;

    while (goOn)
    {
        int currentValue = 0;
        
        if (currentL1Node != null)
        {
            currentValue += currentL1Node.val;
            currentL1Node = currentL1Node.next;
        }
        if(currentL2Node != null)
        {
            currentValue += currentL2Node.val;
            currentL2Node = currentL2Node.next;
        }

        currentValue += carry;
        carry = 0;
        if (currentValue >= 10)
        {
            currentValue -= 10;
            carry = 1;
        }

        if (currentResultNode == null)
        {
            result = new ListNode(currentValue);
            currentResultNode = result;
        }
        else
        {
            currentResultNode.next = new ListNode(currentValue);
            currentResultNode = currentResultNode.next;
        }

        if (currentL2Node == null && currentL1Node == null && carry == 0) goOn = false;
    }

    return result;
}


ListNode MakeListNodeFromArray(int[] arr)
{
    ListNode node = new ListNode(arr[0]);
    ListNode curr = node;
    for (int i = 1; i < arr.Length; i++)
    {
        curr.next = new ListNode(arr[i]);
        curr = curr.next;
    }
    return node;
}