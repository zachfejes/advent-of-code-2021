# Advent of Code 2021

My solutions to the [Advent of Code 2021 challenge](https://adventofcode.com/2021).

I'm going to try doing ALL of this in C# (.NET), through Test Driven Development.


## Udates

Day 1 Challenges A & B Complete: I've refactored and it's now running at O(n), n = # of lines in the text file

> Note: Technically it's running closer to O(2n) because I currently iterate through the loop twice, assuming the file needs to be parsed before each run. This was decreased from the previous O(3n) when I first comleted the problem. I managed to simplify the unsmoothed code by making it a subset of the smoothed code (just with a window size of 1).

Also - I just realized that my local VSCode git settings have my account still set cglobally to an old off-prem work account. I've udated it, but it's crummy because most of my contributions so far are attributed to that other profile. Hopefully this change has fixed it.