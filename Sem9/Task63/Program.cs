Console.WriteLine("Enter the natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return; 
    NaturalNumbers(num - 1);   // работает со стеком, поэтому вывод будет в обратном порядке (нужном нам) - в первую очередь выполняется
    Console.Write($"{num} ");  // рекурсивный вызов и всё, что до него, а уже потом всё остальное 
}                              // (если CW поставить до неё - порядок будет привычный по убыванию)    
