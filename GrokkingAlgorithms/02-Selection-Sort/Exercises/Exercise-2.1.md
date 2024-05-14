2.1. Suppose you’re building an app to keep track of your finances. Every day, you write down everything you spent money on. At the end of the month, you review your expenses and sum up how much you spent. So you have lots of inserts and a few reads. Should you use an array or a list?

> For an app in which I'd be writting every day and reading once a month, a list would be the optimal choice between the two, since it has a run time of O(n) for reading, which will happen only a few times, and O(1) for insertions, which will be happening frequently.
> 
