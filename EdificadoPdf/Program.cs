// See https://aka.ms/new-console-template for more information

//*************************************************************************************
/*Toma el tipo de envio de la cuota conjunta(1 y 2), aquellas chapas que no tengan el mismo tipo de envio
 toman el mismo valor de la cuota 1*/


//*************************************************************************************


TrabajoAEcxel pro = new TrabajoAEcxel();

pro.LeerBase();

public class TrabajoAEcxel
{

    public string PathOrigen = "C:\\Users\\nicol.cruz\\Desktop\\Mora\\POOL.PROD.IISOFENC.C522.EDMA.txt";


    //@"\\arba.gov.ar\DE\GGTI\Gerencia de Produccion\Mantenimiento\Departamento de Emisiones\autoc1.txt"/
    /* "C:\\Users\\nicol.cruz\\Desktop\\nuevo_(1000).txt"; */

    public string PathDestino = "C:\\Users\\nicol.cruz\\Desktop\\Mora\\ResNet.txt";


    string DestinApelliNombreI = string.Empty;
    string DestinApelliNombreD = string.Empty;
    string DestinLocaliI = string.Empty;
    string DestinLocaliD = string.Empty;
    string DestinCalleI = string.Empty;
    string DestinCalleD = string.Empty;
    string line2 = "";
    string part1 = "";
    string part2 = "";
    bool flag = false;

    public void LeerBase()
    {

        String line;
        String line1;


        string LineaNueva = "";

        using (StreamReader sr = new StreamReader(PathOrigen))
        {

            try
            {



                while ((line = sr.ReadLine()) != null)
                {


                    if (line != "")
                    {

                        DestinApelliNombreI = line.Substring(39, 30)+"|";
                        DestinApelliNombreD = line.Substring(3495, 30) + "|";
                        DestinLocaliI = line.Substring(222, 30) + "|";
                        DestinLocaliD = line.Substring(3678, 30) + "|";
                        DestinCalleI = line.Substring(72, 35);
                        DestinCalleD = line.Substring(3528, 35);

                       

                            

                            line = DestinApelliNombreI + DestinLocaliI + DestinCalleI;
                            //line1 = DestinApelliNombreD + DestinLocaliD + DestinCalleD;
                            flag = false;

                        


                        //Console.WriteLine(line);

                        EscribirBase(line);
                       // EscribirBase(line1);

                    }


                }
                sr.Close();
                //Console.ReadLine();
                //Console.WriteLine("Tipo de Envio:  " + TipoEnvio);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

    }



    public void EscribirBase(string Linea)
    {

        string final = "";

        final = Linea;

        //Console.WriteLine(final);



        using (StreamWriter sw = new StreamWriter(PathDestino, true))
        {

            try
            {
                sw.WriteLine(final);
                //sw.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


        }


    }

}