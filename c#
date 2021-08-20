using System;
namespace TrainigSample{
    class Program{
        static void Main (string[] args){
            int[] inputNumber = { };
            Program.Prompt(false);
            while(true){
                string input = Console.ReadLine();
                bool stop;
                switch(input){
                    case"":
                        stop = true;
                        break;
                    default:
                        stop = false;
                        break;
                }
                if (stop == true){
                    break;
                }
                int parsedInput;
                bool parseResult = Int32.TryParse(input,out parsedInput);
                if (parseResult){
                    Program.Prompt(true);
                    continue;
                }
                int[] tempInputNumbers = new int[inputNumbers.Length + 1] ;
                Array.Copy(inputNumbers,tempInputNumbers,inputNumbers.Length);
                tempInputNumbers[tempInputNumbers.Length - 1] = parsedInput;
                inputNumbers = tempInputNumbers;
            }
            int total = 0;
            foreach (int number in inputNumbers){
                total += number;
            }
            double average = (double)total / inputNumbers.Length;
            Console.WriteLine();
            Console.WriteLine("___________________");
            Console.WriteLine("入力された数値は、次の" + inputNumbers.Length + "個の値です。");
            int index = 0;
            do{
                Console.WriteLine(inputNumbers[index++]);
            }
            while (index < inputNumbers.Length);
            Console.WriteLine();
            Console.WriteLine("合計は" + total + "です。");
            Console.WriteLine("平均は" + average + "です。");
            Console.WriteLine();
            Console.WriteLine("何かキーを押して終了してください。");
            Console.ReadKey();
        }
        private static void Prompt(bool error){
            if (error){
                Console.WriteLine("入力値に誤りがあります。");
            }
            string message = "数値を入力し、Enterキーを押してください。";
            message += "¥n";
            message += "数値の入力が終わったら、そのまま、もう一度Enterキーを押してください。";
            Console.WriteLine(message);
        }
    }
}
