using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BabaTincheAirlines
    {
        static void Main()
        {
            int firstTicket = 7000;
            int businessTicket = 3500;
            int economyTicket = 1000;

            double firstMax = (12 * firstTicket) + ((12*firstTicket) * 0.005);
            double businessMax = (28 * businessTicket) + ((28*businessTicket) * 0.005);
            double economyMax = (50 * economyTicket) + ((50*economyTicket) * 0.005);
            // is ok to here
            
                   
            string[] firstClass = Console.ReadLine().Split(' ');
            int fCPasangers = int.Parse(firstClass[0]);
            int fCFrequentFlyers = int.Parse(firstClass[1]);
            int fCmeal = int.Parse(firstClass[2]);
            double firstFrequent = (fCFrequentFlyers*firstTicket) - ((fCFrequentFlyers* firstTicket)*0.7);
            double firstMeal = ((fCmeal* firstTicket)*0.005)+(fCmeal*firstTicket); // 0.5% = 0.005?
            double left = (fCPasangers - (fCFrequentFlyers + fCmeal)) * firstTicket; // this is OK
            double firstResult = firstFrequent + firstMeal + left;
 

            string[] businessClass = Console.ReadLine().Split(' ');
            int bCPasangers = int.Parse(businessClass[0]);
            int bCFrequentFlyers = int.Parse(businessClass[1]);
            int bCmeal = int.Parse(businessClass[2]);
            double businessFrequent = (bCFrequentFlyers*businessTicket) - ((bCFrequentFlyers * businessTicket) * 0.7);
            double businessMeal = ((bCmeal * businessTicket) * 0.005) + (bCmeal*businessTicket);
            double businessLeft = (bCPasangers - (bCFrequentFlyers + bCmeal)) * businessTicket;
            double businessResult = businessFrequent + businessMeal + businessLeft;


            string[] economyClass = Console.ReadLine().Split(' ');
            int eCPasangers = int.Parse(economyClass[0]);
            int eCFrequentFlyers = int.Parse(economyClass[1]);
            int eCmeal = int.Parse(economyClass[2]);
            double economyFrequent = (eCFrequentFlyers*economyTicket) - ((eCFrequentFlyers * economyTicket) * 0.7);
            double economyMeal = ((eCmeal * economyTicket) * 0.005) + (eCmeal*economyTicket);
            double economyLeft = (eCPasangers - (eCFrequentFlyers + eCmeal)) * economyTicket;
            double economyResult = economyFrequent + economyMeal + economyLeft;

            
            int resultAll = (int)firstResult + (int)businessResult + (int)economyResult;
            int difference = ((int)firstMax + (int)businessMax + (int)economyMax) - resultAll; // ?

            Console.WriteLine("{0}",resultAll);
            Console.WriteLine("{0}", difference);
        }
    }