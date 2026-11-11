// 1

// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }

// int max = 1;
// int res = 1;

// for (int i = 1; i < n; i++)
// {
//     if (arr[i] == arr[i - 1])
//     {
//         res++;
//     }
//     else
//     {
//         res = 1;
//     }

//     if (res > max)
//     {
//         max = res;
//     }
// }

// Console.WriteLine(max);

//2
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }

// bool isPalindrome = true;
// for (int i = 0; i < n / 2; i++)
// {
//     if (arr[i] != arr[n - 1 - i])
//     {
//         isPalindrome = false;
//         break;
//     }
// }

// Console.WriteLine(isPalindrome ? "Yes" : "No");


//5

// int n = int.Parse(Console.ReadLine());

// int [] arr = new int [n];

// for(int i = 0 ; i< n ; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//     int max = 0;

//  for(int i= 0 ; i < n ; i++)
// {
//     if(arr[i] > max) max = arr[i];

//     }

//     Console.WriteLine(max);
//

//7
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Multiply(ref a, ref b);

// Console.WriteLine("a = " + a);
// Console.WriteLine("b = " + b);

// void Multiply(ref int a, ref int b)
// {
//     a *= 2;
//     b *= 2;
// }
// 8 


// int n = int.Parse(Console.ReadLine());
// int [] arr = new int [n];

//     for(int i = 0 ; i<n ; i++)
//     {
//         arr[i]=int.Parse(Console.ReadLine());
//     }
//      int c=0;
//      for(int i=0; i < n ; i++)
//     {
    
//         if(arr[i] % 2 == 0)
//     {
//         c++;
//     }

        
    
//     }

//     Console.WriteLine(c);

//10

// int n = int.Parse(Console.ReadLine());

// for(int i = n ; i > 0 ; i--)
// {
//     Console.WriteLine(i+" ");
// }

//9
// int n = int.Parse(Console.ReadLine());

// int [] arr = new int [n];

// for(int i=0 ; i< n ; i++)
// {
//     arr[i]=int.Parse(Console.ReadLine());
// }
// int sum=0;
// int c=0;
// int v=0;
// for(int i = 0 ; i< n ; i++) 
// {
//     v++;
//     sum+=i;
//     if(sum / v <= i)
//     {
//         c++;
//     }
// }
 
//   Console.WriteLine(c);



//6
