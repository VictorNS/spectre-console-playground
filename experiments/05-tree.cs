#:package Spectre.Console@0.57.0

using Spectre.Console;

var tree = new Tree("Animal Kingdom");

var mammals = tree.AddNode("Mammals");
var cats = mammals.AddNode("Cats");
cats.AddNode("Lion");
cats.AddNode("Tiger");
cats.AddNode("Cheetah");
var dogs = mammals.AddNode("Dogs");
dogs.AddNode("Wolf");
dogs.AddNode("Fox");

var birds = tree.AddNode("Birds");
birds.AddNode("Eagle");
birds.AddNode("Penguin");
var parrots = birds.AddNode("Parrots");
parrots.AddNode("Macaw");
parrots.AddNode("Cockatoo");

var reptiles = tree.AddNode("Reptiles");
reptiles.AddNode("Crocodile");
reptiles.AddNode("Komodo Dragon");

AnsiConsole.Write(tree);
