using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB
{
    internal class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public List<Actor> Actors { get; set; }

        public Movie(string title, int runtime, List<Actor> actors)
        {
            Title = title;
            RunTime = runtime;
            Actors = actors;
        }

        public virtual void PrintInfo()
        {
            Console.Write($"Filmen {Title} är {RunTime} min lång, och har följande skådespelare: ");
            foreach (var actor in Actors)
            {
                Console.Write($"{actor.Name}(född: {actor.BirthYear}), ");
            }
        }
    }

    class Comedy : Movie
    {
        public int NumberOfFunnyScenes  { get; set; }

        public Comedy(string title, int runtime, List<Actor> actors, int numberoffunnyscenes) : base(title, runtime, actors)
        {
            NumberOfFunnyScenes = numberoffunnyscenes;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Filmen innehåller {NumberOfFunnyScenes} roliga scener.");
        }
    }

    class Action : Movie
    {
        public int NumberOfShotsFired { get; set; }

        public Action(string title, int runtime, List<Actor> actors, int numberofshotsfired) : base(title, runtime, actors)
        {
            NumberOfShotsFired = numberofshotsfired;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"I filmen skjuts det {NumberOfShotsFired} gånger.");
        }
    }

    class SciFi : Movie
    {
        public int NumberOfSpaceShips { get; set; }

        public SciFi(string title, int runtime, List<Actor> actors, int numberofspaceships) : base(title, runtime, actors)
        {
            NumberOfSpaceShips = numberofspaceships;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Filmen innehåller minst {NumberOfSpaceShips} rymdskepp.");
        }
    }
}
