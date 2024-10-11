using System;
namespace LearnKTLT
{
	public class Array2DNext
	{
		public static void Main(string[] args)
		{
            Console.Write("Nhap so dong(row): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot(col): ");
            int col = int.Parse(Console.ReadLine());

            // khoi tao va khai bao mang 2 chieu
            int[,] intArrA = new int[row, col];
            RandomInputEmlement(ref intArrA);
            PrintArr2D(intArrA); Console.WriteLine();
            int[,] intArrB = new int[row, col];
            RandomInputEmlement(ref intArrB);
            PrintArr2D(intArrB); Console.WriteLine();

            Console.WriteLine("Ket qua la: ");
            int[,] intArrC = Plus2Matrix(intArrA, intArrB);
            PrintArr2D(intArrC);

            Console.ReadKey();
        }

        //Random cho cac gia tri cua mang
        public static void RandomInputEmlement(ref int[,] intArr)
        {
            int row = intArr.GetLength(0);
            int col = intArr.GetLength(1);

            Random a = new Random();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    intArr[r, c] = a.Next(1, 100); ;
                }
            }
        }

        // Xuat mang 2 chieu
        public static void PrintArr2D(int[,] intArr)
        {
            for (int c = 0; c < intArr.GetLength(0); c++)
            {
                for (int l = 0; l < intArr.GetLength(1); l++)
                {
                    Console.Write(intArr[c, l] + " ");
                }
                Console.WriteLine();
            }
        }

        // Xuat mang 1 chieu
        public static void PrintArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        // Xuat ra danh sach
        public static void PrintList(List<int> listA)
        {
            foreach (int item in listA)
            {
                Console.Write(item + " ");
            }
        }

        // tim so lon nhat tren dong thu k cua bang a
        public static int MaxInRowK(int[,] intArr,int k)
        {
            int max = intArr[k-1,0];

            for(int col = 1; col < intArr.GetLength(1); col++)
            {
                if (max < intArr[k-1, col])
                {
                    max = intArr[k-1, col];
                }
            }

            return max;
        }

        // tim so be nhat tren cot k cua bang a
        public static int MinInColK(int[,] intArr, int k)
        {
            int min = intArr[0, k - 1];

            for(int row = 1; row < intArr.GetLength(0); row++)
            {
                if (min > intArr[row, k - 1])
                {
                    min = intArr[row, k - 1];
                }
            }

            return min;
        }

        // tim tat ca cac so nguyen to trong bang a
        public static List<int> FindAllNumberNguyenTo(int[,] intArr)
        {
            List<int> DanhSachSoNguyenTo = new List<int>();

            for(int row = 0; row < intArr.GetLength(0); row++)
            {
                for(int col = 0; col < intArr.GetLength(1); col++)
                {
                    bool isCheck = CheckSoNguyenTo(intArr[row, col]);
                    if(isCheck == true)
                    {
                        DanhSachSoNguyenTo.Add(intArr[row, col]);
                    }
                }
            }

            return DanhSachSoNguyenTo;
        }

        // kiem tra mot so nguyen co phai so nguyen to hay khong
        public static bool CheckSoNguyenTo(int a)
        {
            int count = 0;

            for(int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                return true;
            }
            else return false;
        }

        // ham sap xep tang dan tren dong k
        public static int[] SapXepTangDanRowK(int[,] intArr, int k)
        {
            int[] arr = new int[intArr.GetLength(1)];

            // nhap dong k vao mang arr
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = intArr[k-1, i];
            }

            // interchange sort
            for(int i =0;i<arr.Length;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }

            return arr;
        }

        // ham sap xep giam dan tren cot k
        public static int[] SapXepGiamDanColK(int[,] intArr, int k)
        {
            int[] arr = new int[intArr.GetLength(0)];

            // nhap dong k vao mang arr
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = intArr[i, k-1];
            }

            // interchange sort
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }

            return arr;
        }

        // hoan doi vi tri cua hai so trong mang
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // hoan doi hai hang cho nhau
        public static void Swap2Row(ref int[,] arrInt, int k1, int k2)
        {
            // b1: tao mot mang moi
            int[] newArr = new int[arrInt.GetLength(1)];

            // b2: lua gia tri o k1 vao mang moi
            for(int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arrInt[k1 - 1, i];
            }

            // b3: tao lai gia tri cua k1 = k2
            for(int col = 0; col < arrInt.GetLength(1); col++)
            {
                arrInt[k1 - 1, col] = arrInt[k2 - 1, col];
                arrInt[k2 - 1, col] = newArr[col];
            }
        }

        // cong hai ma tran
        public static int[,] Plus2Matrix(int[,] arr2A, int[,] arr2B)
        {
            // khai bao va khoi tao ma tran c
            int[,] arr2C = new int[arr2A.GetLength(0), arr2A.GetLength(1)];

            // tien hanh cong ma tran
            for(int row = 0; row < arr2A.GetLength(0); row++)
            {
                for(int col =0;col< arr2A.GetLength(1); col++)
                {
                    arr2C[row, col] = arr2A[row, col] + arr2B[row, col];
                }
            }

            return arr2C;
        }

    }
}

