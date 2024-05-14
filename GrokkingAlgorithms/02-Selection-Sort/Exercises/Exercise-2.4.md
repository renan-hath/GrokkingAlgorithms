2.4. People sign up for Facebook pretty often, too. Suppose you decided to use an array to store the list of users. What are the downsides of an array for inserts? In particular, suppose you’re using binary search to search for logins. What happens when you add new users to an array?

> Arrays have a run time of O(n) for inserts, which makes it not the most optimal data structure to be used for such operations, and every time a new user is added, the array needs to be sorted again to make sure it is in alphabetical order so binary search remains possible.
