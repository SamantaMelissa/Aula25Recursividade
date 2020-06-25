namespace Aula25Recursividade
{
    public class Fibonacci
    {
        //RECURSIVIDADE --> Criação de método, e chamamos ele dentro dele mesmo. Como se fosse um ciclo, até dar uma condição para ele parar.
    
        public void GerarSequenciaFibonacci(int numero1, int numero2, int vezes){
        //vezes --> A condição de parada
            if(vezes >= 0){
                System.Console.WriteLine(numero1);
                GerarSequenciaFibonacci(numero2, numero1+numero2, vezes -1);
            }
        }

        public int GerarFatorial(int numero){
            //Fatorial--> 5! = 5x4x3x2x1 
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    
    
    
    
    
    
    
    }
}