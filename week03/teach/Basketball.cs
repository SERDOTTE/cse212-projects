/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {

        // Below is the documentation for the logic to be implemented:
            // Step 1: Create a map (dictionary) to store player IDs and their total points
                // Key: Player ID (string)
                // Value: Total points accumulated across all seasons (int)
            // Step 2: Read the basketball.csv file
            // Step 3: Process each row and build the map containing the total points per player
            // Step 4: Convert the map into an array to facilitate sorting
            // Step 5: Sort the array by points in descending order
            // Step 6: Display the 10 players with the highest total points

        // Step:1  
        var players = new Dictionary<string, int>();

        // Step 2: 
        using var reader = new TextFieldParser("basketball.csv");  // CSV file reader - Open the CSV file for reading
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row

        // Step 3:
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];      // Column 0: Player ID
            var points = int.Parse(fields[8]); // Column 8: Points in this season

            // Add points to the player's total (or initialize if first season)
            if (players.ContainsKey(playerId))
                players[playerId] += points;  // Accumulate points for returning players
            else
                players[playerId] = points;   // Initialize for new players
        }

        // Step 4:
        var topPlayers = players.ToArray();
        
        // Step 5: 
        Array.Sort(topPlayers, (p1, p2) => p2.Value - p1.Value);

        // Step 6: 
        Console.WriteLine();
        for (var i = 0; i < 10; ++i)
        {
            Console.WriteLine($"#{i + 1} - Player: {topPlayers[i].Key}, Total Points: {topPlayers[i].Value}");
        }
    }
}