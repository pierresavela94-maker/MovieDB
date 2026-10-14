namespace MovieDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieDB = new();

            movieDB.Add(new Comedy("Superbad", 113, new List<Actor>
            {
                new Actor("Jonah Hill", 1983),
                new Actor("Michael Cera", 1988),
                new Actor("Christopher Mintz-Plasse", 1989)
            }, 35));
            movieDB.Add(new Comedy("The Hangover", 100, new List<Actor>
            {
                new Actor("Bradley Cooper", 1975),
                new Actor("Ed Helms", 1974),
                new Actor("Zach Galifinakis", 1969)
            }, 30));

            movieDB.Add(new Action("Die Hard", 132, new List<Actor>
            {
                new Actor("Bruce Willis", 1955),
                new Actor("Alan Rickman", 1946),
                new Actor("Bonnie Bedelia", 1948)
            }, 300));
            movieDB.Add(new Action("John Wick", 101, new List<Actor>
            {
                new Actor("Keanu Reeves", 1964),
                new Actor("Willem Dafoe", 1955),
                new Actor("Ian McShane", 1942)
            }, 2000));

            movieDB.Add(new SciFi("Star Wars: Episode IV - A New Hope", 121, new List<Actor>
            {
                new Actor("Mark Hamill", 1951),
                new Actor("Harrison Ford", 1942),
                new Actor("Carrie Fisher", 1956)
            }, 50));
            movieDB.Add(new SciFi("Alien", 117, new List<Actor>
            {
                new Actor("Signouey Weaver", 1949),
                new Actor("Tom Skerritt", 1933),
                new Actor("John Hurt", 1940)
            }, 3));

            foreach (var movie in movieDB)
            {
                movie.PrintInfo();
                Console.WriteLine();
            }
            

        }
    }
}
