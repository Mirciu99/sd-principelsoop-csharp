using System;
using System.Collections.Generic;

namespace OOPCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() { new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Rick", "Jack", 6175225555), new OmniaClubPromoter("Rachel", "Mark", 6285555555) };

            foreach(var promoter in promoters)
            {
                //dynamic polymorphism (same method different behavior
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>() { new BookWriter("Rad", "Mircea"), new BookWriter("Rad", "Bogdan"), new BlogWriter("Rad", "George") };

            foreach (var writer in writers)
            {
                writer.Write();
            }


            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() { new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Rick", "Jack", 6175225555) };

            foreach (var builder in bodyBuilders)
            {
                builder.Workout();
            }


            List<IVlogger> vloggers = new List<IVlogger>() { new XSClubPromoter("Jon", "Jones", 6175555555), new BookWriter("Rad", "Bogdan"), new BlogWriter("Rad", "George") };

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }

        }
    }
}
