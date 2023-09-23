// See https://aka.ms/new-console-template for more information

int student1, student2, student3, student4, student5, student6, student7, student8, student9, student10;

Console.WriteLine("Ingresa nota del primer estudiante");
student1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del segundo estudiante");
student2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del tercer estudiante");
student3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del cuarto estudiante");
student4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del quinto estudiante");
student5 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del sexto estudiante");
student6 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del septimo estudiante");
student7 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del octavo estudiante");
student8 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del noveno estudiante");
student9 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa nota del decimo estudiante");
student10 = int.Parse(Console.ReadLine());




while(true){
    int[] notaBaja = new int[] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10  };
    int[] notaMedia = new int[] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10  };
    int[] notaAlta = new int[] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10  };


    Console.WriteLine("Frecuencia de los estudiantes que sacaron una calificación baja(de 0 a 4)");
    Console.WriteLine("Frecuencia de los estudiantes que sacaron una calificación media(de 5 a 7)");
    Console.WriteLine("Frecuencia de los estudiantes que sacaron una calificación baja(de 8 a 10)");
    string selection = Console.ReadLine();

    switch (selection)
    {
        case "1":
            int conteoBaja = 0;
            for (int i = 0; i < notaBaja.Length; i++)
            {
                if (notaBaja[i] >= 0 && notaBaja[i] <= 4)

                {
                    conteoBaja++;

                }

            }
            Console.WriteLine("Frecuencia de nota media es:" + conteoBaja);
            break;
        case "2":
            int conteoMedia = 0;

            for (int i = 0; i < notaMedia.Length; i++)
            {
                if (notaMedia[i] >= 5 && notaMedia[i] <= 7)
                {
                    conteoMedia++;

                }

            }
            Console.WriteLine("Frecuencia de nota media es:" + conteoMedia);
            break;
        case "3":
            int conteoAlta = 0;
            for (int i = 0; i < notaAlta.Length; i++)
            {
                if (notaAlta[i] >= 8 && notaAlta[i] <= 10)
                {
                    conteoAlta++;

                }

            }
            Console.WriteLine("Frecuencia de nota alta es:" + conteoAlta);
            break;
    }
}










