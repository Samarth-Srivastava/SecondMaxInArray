using System;
using System.IO;
using System.Collections.Generic;

class MAIN  {
    public static void Main(string[] args) {
        int testcase = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < testcase; i++){
            string line = Console.ReadLine();
            string[] n_arr_str = line.Split(' ');
        
            int N = Convert.ToInt32(n_arr_str[0]);
        
            List<int> A = new List<int>();
            for(int j = 0; j < N; j++){
                A.Add(Convert.ToInt32(n_arr_str[j+1]));
            }

            if(N > 1){
                int max_index = 0;
                for(int j = 1; j < N; j++){
                    if(A[j] > A[max_index]){
                        max_index = j;
                    }
                }
                int secondMax = int.MinValue;
                for(int j = 0; j < N; j++){
                    if(A[j] > secondMax && j != max_index){
                        secondMax = A[j];
                    }
                }
                Console.WriteLine(secondMax);
            }
            else{
                Console.WriteLine(-1);
            }   
        }
    }
}
