Console Application<br>
Exercises: Functional Programming
# PredicateParty
Paul’s parents are on a vacation for the holidays and he is planning an epic party at home. Unfortunately, his organizational skills are next to non-existent, so you are given the task to help him with the reservations.


On the __first line__, you receive __a list with all the people__ that are coming. On the __next lines__, until you get the __"Party!" command__, you may be asked to __double__ or __remove__ all the people that apply to a given __criteria__. There are __three different criter__ia: 
- Everyone that has a name __starting with__ a given string
- Everyone that has a name __ending with__ a given string
- Everyone that has a name with __a given length__.


Finally, __print all the guests__ who are going to the party __separated by ", "__ and then add the ending __"are going to the party!"__. If there are __no guests__ going to the party print __"Nobody is going to the party!"__. See the examples below:
## Examples
Input|Output
-----|------
Peter Misha Stephen<br>Remove StartsWith P<br>Double Length 5<br>Party!|Misha, Misha, Stephen are going to the party!
Peter<br>Double StartsWith Pete<br>Double EndsWith eter<br>Party!|Peter, Peter, Peter, Peter are going to the party!
Peter<br>Remove StartsWith P<br>Party!|Nobody is going to the party!
