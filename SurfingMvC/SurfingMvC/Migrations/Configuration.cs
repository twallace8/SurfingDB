namespace SurfingMvC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SurfingMvC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SurfingMvC.Models.surfDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SurfingMvC.Models.surfDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.surfs.AddOrUpdate(
              p => p.ID,
              new surf { ID = 1, Picture = "https://s-media-cache-ak0.pinimg.com/originals/b6/35/4f/b6354fc5ac6c503ff33bcf3a27e9cfba.jpg", Location = "Maverick's, California, USA", Continent = "North America", Wave_type = "Reef Break", Wave_Size = 8, Level = "Advanced" },
              new surf { ID = 2, Picture = "https://ilovetravelingandexploring.files.wordpress.com/2014/08/cloud-nine-siargao-island-philippines.jpg", Location = "Cloud Nine, Siargao Island, Philippines.", Continent = "Asia", Wave_type = "Reef Break", Wave_Size = 7, Level = "Advanced" },
              new surf { ID = 3, Picture = "http://cdn.grindtv.com/uploads/2014/04/Joel-Parkinson.jpg", Location = "Margaret River Valley, Australia", Continent = "Australasia Pacific", Wave_type = "Reef Break", Wave_Size = 5, Level = "Intermediate" },
              new surf { ID = 4, Picture = "http://www.best-beaches.com/images/malibu-beaches/malibu-ca-beaches.jpg", Location = "Surfrider Beach, Malibu, California, USA.", Continent = "North America", Wave_type = "Reef Break", Wave_Size = 4, Level = "Intermediate" },
              new surf { ID = 5, Picture = "http://backpackershawaii.com/wp-content/uploads/pipeline_hawaii_2008_BPH.jpg", Location = "Pipeline, Oahu, Hawaii", Continent = "North America", Wave_type = "Reef Break", Wave_Size = 10, Level = "Highly Advanced" },
              new surf { ID = 6, Picture = "https://articsurf.files.wordpress.com/2012/03/20-13-43_ordinary_6602.jpg", Location = "Hoddevik, Norway", Continent = "Europe", Wave_type = "Beach break", Wave_Size = 4, Level = "Beginner" },
              new surf { ID = 7, Picture = "https://i.ytimg.com/vi/m-TrdAEu6EA/maxresdefault.jpg", Location = "Supertubes, Jeffrey's Bay, South Africa", Continent = "Africa", Wave_type = "Point Break", Wave_Size = 7, Level = "Advanced" },
              new surf { ID = 8, Picture = "http://www.perfxp.com/img/p/1/5/1/0/1510-large_atch.jpg", Location = "Portugal Centro  Buarcos", Continent = "Europe", Wave_type = "Reef break", Wave_Size = 5, Level = "Intermediate" },
              new surf { ID = 9, Picture = "https://media.livethelife.tv/wp-content/uploads/2015/12/mark-anderson-jaws-maui-hawaii-.jpg", Location = "Jaws, Maui, Hawaii", Continent = "North America", Wave_type = "Reef Break", Wave_Size = 18, Level = "Highly Advanced" },
              new surf { ID = 10, Picture = "https://www.gapyear.com/images/content/Images/13_06_06-zb-magicseaweed-thursosurf.jpg", Location = "Thurso East, Scotland", Continent = "Europe", Wave_type = "Reef break", Wave_Size = 6, Level = "Intermediate" },
              new surf { ID = 11, Picture = "http://img.wennermedia.com/920-width/mj-618_348_honolua-bay-maui-hawaii-best-surf-spots-in-the-world.jpg", Location = "Honolua Bay, Maui, Hawaii", Continent = "North America", Wave_type = "Point Break", Wave_Size = 7, Level = "Advanced" },
              new surf { ID = 12, Picture = "https://www.surfholidays.com/assets/images/blog/2010-09-22-History-of-the-Quiksilver-Pro-France-1.jpg", Location = "Hossegor, France", Continent = "Europe", Wave_type = "Beach Break", Wave_Size = 6, Level = "Intermediate" },
              new surf { ID = 13, Picture = "http://www.cornwall-online.co.uk/waterside/images/surfing-fistral.jpg", Location = "Fistral Bay, Cornwall, UK", Continent = "Europe", Wave_type = "Beach break", Wave_Size = 4, Level = "Beginner" },
              new surf { ID = 14, Picture = "http://www.travelsupermarket.com/blog/wp-content/uploads/2012/05/Croyde.jpg", Location = "Croyde Bay, Devon", Continent = "Europe", Wave_type = "Beach break", Wave_Size = 4, Level = "Beginner" },
              new surf { ID = 15, Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Kitesurfteahupoo.jpg/250px-Kitesurfteahupoo.jpg", Location = "Teahupo'o, Tahiti, French Polynesia", Continent = "Australasia Pacific", Wave_type = "Reef Break", Wave_Size = 8, Level = "Highly Advanced" },
              new surf { ID = 16, Picture = "http://www.elportosurfschool.com/sitebuildercontent/sitebuilderpictures/jn2_edited-1.jpg", Location = "Cloudbreak, Tavarua Island, Fiji", Continent = "Australasia Pacific", Wave_type = "Reef Break", Wave_Size = 7, Level = "Advanced" },
              new surf { ID = 17, Picture = "http://i.cdn-surfline.com/surfnews/images/2013/04_april/bali/full/TrevorMurphy_AlikRudiarta_Uluwatu_Bali.jpg", Location = "Uluwatu Bali, Indonesia", Continent = "Asia", Wave_type = "Reef Break", Wave_Size = 7, Level = "Advanced" }); 
        }
    }
}
