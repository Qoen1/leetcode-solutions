// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] ints = {
    2,7,11,15
};
int target = 9;

int[] arr = TwoSum(ints, target);
string arrStr = "{\n";
foreach (int i in arr)
{
    arrStr += " " + i.ToString() + ",\n";
}
arrStr += "}";

Console.WriteLine(arrStr);

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int num = nums[i];
        for (int j = i + 1; j < nums.Length; j++)
        {

            int toAdd = nums[j];
            if (num + toAdd == target)
            {
                return new[] { i, j };
            }
        }
    }

    throw new Exception("sadge");
}