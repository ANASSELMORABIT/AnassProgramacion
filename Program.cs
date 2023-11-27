internal class Program
{
    private static void Main(string[] args)
    {
 /*Tarera1:*/
 int i,Suma,nota;
 float Media;
 Suma=0;
 for(i=1;i<=3;i++){
     Console.WriteLine("ingresa  nota:");
     nota=Convert.ToInt32(System.Console.ReadLine());
     Suma=Suma+nota;
 }
 Media=Suma/3;
 Console.WriteLine("La nota media es {0}",Media)
 if(Media>=5){
     Console.WriteLine("aprobada");
 }
 else{
     Console.WriteLine("suspendida");
 }
 /*Tarea2*/
 int Comptador_Par,Comptador_IMPAR,numero;
 Comptador_Par=0;
 Comptador_IMPAR=0;
 do{
     Console.WriteLine("ingresa un numero");
     numero=Convert.ToInt32(System.Console.ReadLine());
     if(numero %2 ==0){
         Comptador_Par++;
     }
     else{
         Comptador_IMPAR++;
     }
 }while(numero != 0);
 Console.WriteLine("Tu ingresas {0} numeros pares y {1} impares",Comptador_Par,Comptador_IMPAR);
/*Tarea 3*/
 int num1,num2,Suma,Multiplica,Resta,operacion;
       
do{
      Console.WriteLine("La computadora:(1-Suma  2-resta  3-Multiplicación   4-Division)");

     Console.WriteLine("ingresa el primero numero:");
     num1=Convert.ToInt32(System.Console.ReadLine());

     Console.WriteLine("ingresa el segundo numero:");
     num2=Convert.ToInt32(System.Console.ReadLine());
     do{
         Console.WriteLine("¿que operacion quieres realizar?");
         operacion=Convert.ToInt32(System.Console.ReadLine()); 
     }while(operacion <1 || operacion >4);
     switch (operacion) {
         case 1: Console.WriteLine ("La suma:");
                 Suma=num1+num2;
                 Console.WriteLine("{0} + {1} ={2}",num1,num2,Suma);
                 break;
         case 2: Console.WriteLine ("La resta :");
                 Resta=num1-num2;
                 Console.WriteLine("{0} - {1} ={2}",num1,num2,Resta);
                 break;
         case 3: Console.WriteLine ("La multiplicacion :");
                 Multiplica=num1*num2;
                 Console.WriteLine("{0} x {1} ={2}",num1,num2,Multiplica);
                 break;
         default : Console.WriteLine ("La division :");
                 while(num2 == 0){
                     Console.WriteLine("ingresa un valor diferente de 0");
                     Console.WriteLine("ingresa el primero numero:");
                     num1=Convert.ToInt32(System.Console.ReadLine());
                     Console.WriteLine("ingresa el segundo numero:");
                     num2=Convert.ToInt32(System.Console.ReadLine());
                 }
                 float Division= (float)num1 / num2;
                 Console.WriteLine("{0} / {1} ={2}",num1,num2,Division);
                 break;
     }
     Console.WriteLine("quires realizar mas operaciones:(Y/N)");
     string respuesta=Console.ReadLine();
    }while(respuesta == "Y");
/*Tarea4*/
 int Rest,NumDNI;
 string LetraDNi;
 do{
     Console.WriteLine("introduzir el numero del decumento:");
     NumDNI=Convert.ToInt32(System.Console.ReadLine()); 
     Rest=NumDNI % 23;
 }while(Rest<0 || Rest>23);
 switch(Rest){
     case 0: LetraDNi="T";
             break;
     case 1: LetraDNi="R";
             break;
     case 2: LetraDNi="W";
             break;
     case 3: LetraDNi="A";
             break;
     case 4: LetraDNi="G";
             break;
     case 5: LetraDNi="M";
             break;
     case 6: LetraDNi="Y";
             break;
     case 7: LetraDNi="F";
             break;
     case 8:LetraDNi="P";
             break;
     case 9:  LetraDNi="D";
             break;
     case 10: LetraDNi="X";
             break;
     case 11: LetraDNi="B";
             break;
     case 12: LetraDNi="N";
             break;
     case 13: LetraDNi="J";
             break;
     case 14: LetraDNi="Z";
             break;
     case 15: LetraDNi="S";
             break;
     case 16: LetraDNi="Q";
             break;
     case 17: LetraDNi="V";
             break;
     case 18: LetraDNi="H";
             break;
     case 19: LetraDNi="L";
             break;
     case 20:  LetraDNi="C";
             break;
     case 21:  LetraDNi="K";
             break;
     default: LetraDNi="E";
             break;
 }
 Console.WriteLine("La letra correspondant a este Documento es :{0}",LetraDNi);
        /*Tarea5*/
 int i,j;
 for(i=1;i<=15;i++){
     for(j=1;j<=i;j++){
         Console.Write("*");
     }
     Console.WriteLine();
 }
        /*Tarea6*/
 int i,j;
 for(i=1;i<=8;i++){
     for(j=1;j<=4;j++){
         if (i%2==0){
             Console.Write("N");
             Console.Write("B");
         }
         else{
             Console.Write("B");
             Console.Write("N");
         }
     }
     Console.WriteLine();
 }

    }
}