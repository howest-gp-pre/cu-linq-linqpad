﻿using Pre.Cu.LINQ.Console.Exercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Cu.LINQ.Console.Exercises
{
    public class ExerciseC : IExercise
    {
        public void Run()
        {
            // TODO 1. Geef alle Pokemon weer die niet tot generatie 1, 2 of 4 behoren en legendary zijn 

            // TODO 2. Geef de Pokemon weer die behoren tot Gen II, behoren tot de category Fire, Psychic of Rock en hebben binnen hun categorie een attackbonus 
            // die hoger ligt dan het gemiddelde.

            // TODO 3. Geef de gemiddelde Hp, Attack en Defense weer voor de pokemon van Generation I per type
        }

        List<Pokemon> pokemons =  new List<Pokemon>()
        {
            new Pokemon(1, "Bulbasaur", "Grass", 45, 49, 49, 65, 65, 45, (PokemonGeneration)0, false),
            new Pokemon(2, "Ivysaur", "Grass", 60, 62, 63, 80, 80, 60, (PokemonGeneration)0, false),
            new Pokemon(3, "Venusaur", "Grass", 80, 82, 83, 100, 100, 80, (PokemonGeneration)0, false),
            new Pokemon(4, "VenusaurMega Venusaur", "Grass", 80, 100, 123, 122, 120, 80, (PokemonGeneration)0, false),
            new Pokemon(5, "Charmander", "Fire", 39, 52, 43, 60, 50, 65, (PokemonGeneration)0, false),
            new Pokemon(6, "Charmeleon", "Fire", 58, 64, 58, 80, 65, 80, (PokemonGeneration)0, false),
            new Pokemon(7, "Charizard", "Fire", 78, 84, 78, 109, 85, 100, (PokemonGeneration)0, false),
            new Pokemon(8, "CharizardMega Charizard X", "Fire", 78, 130, 111, 130, 85, 100, (PokemonGeneration)0,
                false),
            new Pokemon(9, "CharizardMega Charizard Y", "Fire", 78, 104, 78, 159, 115, 100, (PokemonGeneration)0,
                false),
            new Pokemon(10, "Squirtle", "Water", 44, 48, 65, 50, 64, 43, (PokemonGeneration)0, false),
            new Pokemon(11, "Wartortle", "Water", 59, 63, 80, 65, 80, 58, (PokemonGeneration)0, false),
            new Pokemon(12, "Blastoise", "Water", 79, 83, 100, 85, 105, 78, (PokemonGeneration)0, false),
            new Pokemon(13, "BlastoiseMega Blastoise", "Water", 79, 103, 120, 135, 115, 78, (PokemonGeneration)0,
                false),
            new Pokemon(14, "Caterpie", "Bug", 45, 30, 35, 20, 20, 45, (PokemonGeneration)0, false),
            new Pokemon(15, "Metapod", "Bug", 50, 20, 55, 25, 25, 30, (PokemonGeneration)0, false),
            new Pokemon(16, "Butterfree", "Bug", 60, 45, 50, 90, 80, 70, (PokemonGeneration)0, false),
            new Pokemon(17, "Weedle", "Bug", 40, 35, 30, 20, 20, 50, (PokemonGeneration)0, false),
            new Pokemon(18, "Kakuna", "Bug", 45, 25, 50, 25, 25, 35, (PokemonGeneration)0, false),
            new Pokemon(19, "Beedrill", "Bug", 65, 90, 40, 45, 80, 75, (PokemonGeneration)0, false),
            new Pokemon(20, "BeedrillMega Beedrill", "Bug", 65, 150, 40, 15, 80, 145, (PokemonGeneration)0, false),
            new Pokemon(77, "Weepinbell", "Grass", 65, 90, 50, 85, 45, 55, (PokemonGeneration)0, false),
            new Pokemon(78, "Victreebel", "Grass", 80, 105, 65, 100, 70, 70, (PokemonGeneration)0, false),
            new Pokemon(79, "Tentacool", "Water", 40, 40, 35, 50, 100, 70, (PokemonGeneration)0, false),
            new Pokemon(80, "Tentacruel", "Water", 80, 70, 65, 80, 120, 100, (PokemonGeneration)0, false),
            new Pokemon(81, "Geodude", "Rock", 40, 80, 100, 30, 30, 20, (PokemonGeneration)0, false),
            new Pokemon(82, "Graveler", "Rock", 55, 95, 115, 45, 45, 35, (PokemonGeneration)0, false),
            new Pokemon(83, "Golem", "Rock", 80, 120, 130, 55, 65, 45, (PokemonGeneration)0, false),
            new Pokemon(84, "Ponyta", "Fire", 50, 85, 55, 65, 65, 90, (PokemonGeneration)0, false),
            new Pokemon(85, "Rapidash", "Fire", 65, 100, 70, 80, 80, 105, (PokemonGeneration)0, false),
            new Pokemon(86, "Slowpoke", "Water", 90, 65, 65, 40, 40, 15, (PokemonGeneration)0, false),
            new Pokemon(87, "Slowbro", "Water", 95, 75, 110, 100, 80, 30, (PokemonGeneration)0, false),
            new Pokemon(186, "Lanturn", "Water", 125, 58, 58, 76, 76, 67, (PokemonGeneration)1, false),
            new Pokemon(187, "Pichu", "Electric", 20, 40, 15, 35, 35, 60, (PokemonGeneration)1, false),
            new Pokemon(188, "Cleffa", "Fairy", 50, 25, 28, 45, 55, 15, (PokemonGeneration)1, false),
            new Pokemon(189, "Igglybuff", "Normal", 90, 30, 15, 40, 20, 15, (PokemonGeneration)1, false),
            new Pokemon(190, "Togepi", "Fairy", 35, 20, 65, 40, 65, 20, (PokemonGeneration)1, false),
            new Pokemon(191, "Togetic", "Fairy", 55, 40, 85, 80, 105, 40, (PokemonGeneration)1, false),
            new Pokemon(192, "Natu", "Psychic", 40, 50, 45, 70, 45, 70, (PokemonGeneration)1, false),
            new Pokemon(193, "Xatu", "Psychic", 65, 75, 70, 95, 70, 95, (PokemonGeneration)1, false),
            new Pokemon(194, "Mareep", "Electric", 55, 40, 40, 65, 45, 35, (PokemonGeneration)1, false),
            new Pokemon(195, "Flaaffy", "Electric", 70, 55, 55, 80, 60, 45, (PokemonGeneration)1, false),
            new Pokemon(196, "Ampharos", "Electric", 90, 75, 85, 115, 90, 55, (PokemonGeneration)1, false),
            new Pokemon(197, "AmpharosMega Ampharos", "Electric", 90, 95, 105, 165, 110, 45, (PokemonGeneration)1,
                false),
            new Pokemon(198, "Bellossom", "Grass", 75, 80, 95, 90, 100, 50, (PokemonGeneration)1, false),
            new Pokemon(199, "Marill", "Water", 70, 20, 50, 20, 50, 40, (PokemonGeneration)1, false),
            new Pokemon(200, "Azumarill", "Water", 100, 50, 80, 60, 80, 50, (PokemonGeneration)1, false),
            new Pokemon(201, "Sudowoodo", "Rock", 70, 100, 115, 30, 65, 30, (PokemonGeneration)1, false),
            new Pokemon(202, "Politoed", "Water", 90, 75, 75, 90, 100, 70, (PokemonGeneration)1, false),
            new Pokemon(203, "Hoppip", "Grass", 35, 35, 40, 35, 55, 50, (PokemonGeneration)1, false),
            new Pokemon(204, "Skiploom", "Grass", 55, 45, 50, 45, 65, 80, (PokemonGeneration)1, false),
            new Pokemon(205, "Jumpluff", "Grass", 75, 55, 70, 55, 95, 110, (PokemonGeneration)1, false),
            new Pokemon(206, "Aipom", "Normal", 55, 70, 55, 40, 55, 85, (PokemonGeneration)1, false),
            new Pokemon(207, "Sunkern", "Grass", 30, 30, 30, 30, 30, 30, (PokemonGeneration)1, false),
            new Pokemon(208, "Sunflora", "Grass", 75, 75, 55, 105, 85, 30, (PokemonGeneration)1, false),
            new Pokemon(209, "Yanma", "Bug", 65, 65, 45, 75, 45, 95, (PokemonGeneration)1, false),
            new Pokemon(210, "Wooper", "Water", 55, 45, 45, 25, 25, 15, (PokemonGeneration)1, false),
            new Pokemon(211, "Quagsire", "Water", 95, 85, 85, 65, 65, 35, (PokemonGeneration)1, false),
            new Pokemon(212, "Espeon", "Psychic", 65, 65, 60, 130, 95, 110, (PokemonGeneration)1, false),
            new Pokemon(213, "Umbreon", "Dark", 95, 65, 110, 60, 130, 65, (PokemonGeneration)1, false),
            new Pokemon(214, "Murkrow", "Dark", 60, 85, 42, 85, 42, 91, (PokemonGeneration)1, false),
            new Pokemon(215, "Slowking", "Water", 95, 75, 80, 100, 110, 30, (PokemonGeneration)1, false),
            new Pokemon(216, "Misdreavus", "Ghost", 60, 60, 60, 85, 85, 85, (PokemonGeneration)1, false),
            new Pokemon(217, "Unown", "Psychic", 48, 72, 48, 72, 48, 48, (PokemonGeneration)1, false),
            new Pokemon(218, "Wobbuffet", "Psychic", 190, 33, 58, 33, 58, 33, (PokemonGeneration)1, false),
            new Pokemon(219, "Girafarig", "Normal", 70, 80, 65, 90, 65, 85, (PokemonGeneration)1, false),
            new Pokemon(270, "Lugia", "Psychic", 106, 90, 130, 90, 154, 110, (PokemonGeneration)1, true),
            new Pokemon(271, "Ho-oh", "Fire", 106, 130, 90, 110, 154, 90, (PokemonGeneration)1, true),
            new Pokemon(272, "Celebi", "Psychic", 100, 100, 100, 100, 100, 100, (PokemonGeneration)1, false),
            new Pokemon(273, "Treecko", "Grass", 40, 45, 35, 65, 55, 70, (PokemonGeneration)2, false),
            new Pokemon(274, "Grovyle", "Grass", 50, 65, 45, 85, 65, 95, (PokemonGeneration)2, false),
            new Pokemon(275, "Sceptile", "Grass", 70, 85, 65, 105, 85, 120, (PokemonGeneration)2, false),
            new Pokemon(276, "SceptileMega Sceptile", "Grass", 70, 110, 75, 145, 85, 145, (PokemonGeneration)2, false),
            new Pokemon(277, "Torchic", "Fire", 45, 60, 40, 70, 50, 45, (PokemonGeneration)2, false),
            new Pokemon(278, "Combusken", "Fire", 60, 85, 60, 85, 60, 55, (PokemonGeneration)2, false),
            new Pokemon(279, "Blaziken", "Fire", 80, 120, 70, 110, 70, 80, (PokemonGeneration)2, false),
            new Pokemon(280, "BlazikenMega Blaziken", "Fire", 80, 160, 80, 130, 80, 100, (PokemonGeneration)2, false),
            new Pokemon(281, "Mudkip", "Water", 50, 70, 50, 50, 50, 40, (PokemonGeneration)2, false),
            new Pokemon(282, "Marshtomp", "Water", 70, 85, 70, 60, 70, 50, (PokemonGeneration)2, false),
            new Pokemon(283, "Swampert", "Water", 100, 110, 90, 85, 90, 60, (PokemonGeneration)2, false),
            new Pokemon(284, "SwampertMega Swampert", "Water", 100, 150, 110, 95, 110, 70, (PokemonGeneration)2, false),
            new Pokemon(285, "Poochyena", "Dark", 35, 55, 35, 30, 30, 35, (PokemonGeneration)2, false),
            new Pokemon(286, "Mightyena", "Dark", 70, 90, 70, 60, 60, 70, (PokemonGeneration)2, false),
            new Pokemon(287, "Zigzagoon", "Normal", 38, 30, 41, 30, 41, 60, (PokemonGeneration)2, false),
            new Pokemon(288, "Linoone", "Normal", 78, 70, 61, 50, 61, 100, (PokemonGeneration)2, false),
            new Pokemon(289, "Wurmple", "Bug", 45, 45, 35, 20, 30, 20, (PokemonGeneration)2, false),
            new Pokemon(290, "Silcoon", "Bug", 50, 35, 55, 25, 25, 15, (PokemonGeneration)2, false),
            new Pokemon(291, "Beautifly", "Bug", 60, 70, 50, 100, 50, 65, (PokemonGeneration)2, false),
            new Pokemon(292, "Cascoon", "Bug", 50, 35, 55, 25, 25, 15, (PokemonGeneration)2, false),
            new Pokemon(293, "Dustox", "Bug", 60, 50, 70, 50, 90, 65, (PokemonGeneration)2, false),
            new Pokemon(294, "Lotad", "Water", 40, 30, 30, 40, 50, 30, (PokemonGeneration)2, false),
            new Pokemon(295, "Lombre", "Water", 60, 50, 50, 60, 70, 50, (PokemonGeneration)2, false),
            new Pokemon(296, "Ludicolo", "Water", 80, 70, 70, 90, 100, 70, (PokemonGeneration)2, false),
            new Pokemon(297, "Seedot", "Grass", 40, 40, 50, 30, 30, 30, (PokemonGeneration)2, false),
            new Pokemon(298, "Nuzleaf", "Grass", 70, 70, 40, 60, 40, 60, (PokemonGeneration)2, false),
            new Pokemon(299, "Shiftry", "Grass", 90, 100, 60, 90, 60, 80, (PokemonGeneration)2, false),
            new Pokemon(358, "Grumpig", "Psychic", 80, 45, 65, 90, 110, 80, (PokemonGeneration)2, false),
            new Pokemon(359, "Spinda", "Normal", 60, 60, 60, 60, 60, 60, (PokemonGeneration)2, false),
            new Pokemon(360, "Trapinch", "Ground", 45, 100, 45, 45, 45, 10, (PokemonGeneration)2, false),
            new Pokemon(361, "Vibrava", "Ground", 50, 70, 50, 50, 50, 70, (PokemonGeneration)2, false),
            new Pokemon(362, "Flygon", "Ground", 80, 100, 80, 80, 80, 100, (PokemonGeneration)2, false),
            new Pokemon(363, "Cacnea", "Grass", 50, 85, 40, 85, 40, 35, (PokemonGeneration)2, false),
            new Pokemon(364, "Cacturne", "Grass", 70, 115, 60, 115, 60, 55, (PokemonGeneration)2, false),
            new Pokemon(365, "Swablu", "Normal", 45, 40, 60, 40, 75, 50, (PokemonGeneration)2, false),
            new Pokemon(366, "Altaria", "Dragon", 75, 70, 90, 70, 105, 80, (PokemonGeneration)2, false),
            new Pokemon(367, "AltariaMega Altaria", "Dragon", 75, 110, 110, 110, 105, 80, (PokemonGeneration)2, false),
            new Pokemon(368, "Zangoose", "Normal", 73, 115, 60, 60, 60, 90, (PokemonGeneration)2, false),
            new Pokemon(369, "Seviper", "Poison", 73, 100, 60, 100, 60, 65, (PokemonGeneration)2, false),
            new Pokemon(370, "Lunatone", "Rock", 70, 55, 65, 95, 85, 70, (PokemonGeneration)2, false),
            new Pokemon(371, "Solrock", "Rock", 70, 95, 85, 55, 65, 70, (PokemonGeneration)2, false),
            new Pokemon(372, "Barboach", "Water", 50, 48, 43, 46, 41, 60, (PokemonGeneration)2, false),
            new Pokemon(373, "Whiscash", "Water", 110, 78, 73, 76, 71, 60, (PokemonGeneration)2, false),
            new Pokemon(374, "Corphish", "Water", 43, 80, 65, 50, 35, 35, (PokemonGeneration)2, false),
            new Pokemon(375, "Crawdaunt", "Water", 63, 120, 85, 90, 55, 55, (PokemonGeneration)2, false),
            new Pokemon(376, "Baltoy", "Ground", 40, 40, 55, 40, 70, 55, (PokemonGeneration)2, false),
            new Pokemon(377, "Claydol", "Ground", 60, 70, 105, 70, 120, 75, (PokemonGeneration)2, false),
            new Pokemon(378, "Lileep", "Rock", 66, 41, 77, 61, 87, 23, (PokemonGeneration)2, false),
            new Pokemon(493, "Gabite", "Dragon", 68, 90, 65, 50, 55, 82, (PokemonGeneration)3, false),
            new Pokemon(494, "Garchomp", "Dragon", 108, 130, 95, 80, 85, 102, (PokemonGeneration)3, false),
            new Pokemon(495, "GarchompMega Garchomp", "Dragon", 108, 170, 115, 120, 95, 92, (PokemonGeneration)3,
                false),
            new Pokemon(496, "Munchlax", "Normal", 135, 85, 40, 40, 85, 5, (PokemonGeneration)3, false),
            new Pokemon(497, "Riolu", "Fighting", 40, 70, 40, 35, 40, 60, (PokemonGeneration)3, false),
            new Pokemon(498, "Lucario", "Fighting", 70, 110, 70, 115, 70, 90, (PokemonGeneration)3, false),
            new Pokemon(499, "LucarioMega Lucario", "Fighting", 70, 145, 88, 140, 70, 112, (PokemonGeneration)3, false),
            new Pokemon(500, "Hippopotas", "Ground", 68, 72, 78, 38, 42, 32, (PokemonGeneration)3, false),
            new Pokemon(501, "Hippowdon", "Ground", 108, 112, 118, 68, 72, 47, (PokemonGeneration)3, false),
            new Pokemon(502, "Skorupi", "Poison", 40, 50, 90, 30, 55, 65, (PokemonGeneration)3, false),
            new Pokemon(503, "Drapion", "Poison", 70, 90, 110, 60, 75, 95, (PokemonGeneration)3, false),
            new Pokemon(504, "Croagunk", "Poison", 48, 61, 40, 61, 40, 50, (PokemonGeneration)3, false),
            new Pokemon(505, "Toxicroak", "Poison", 83, 106, 65, 86, 65, 85, (PokemonGeneration)3, false),
            new Pokemon(506, "Carnivine", "Grass", 74, 100, 72, 90, 72, 46, (PokemonGeneration)3, false),
            new Pokemon(507, "Finneon", "Water", 49, 49, 56, 49, 61, 66, (PokemonGeneration)3, false),
            new Pokemon(508, "Lumineon", "Water", 69, 69, 76, 69, 86, 91, (PokemonGeneration)3, false),
            new Pokemon(509, "Mantyke", "Water", 45, 20, 50, 60, 120, 50, (PokemonGeneration)3, false),
            new Pokemon(510, "Snover", "Grass", 60, 62, 50, 62, 60, 40, (PokemonGeneration)3, false),
            new Pokemon(511, "Abomasnow", "Grass", 90, 92, 75, 92, 85, 60, (PokemonGeneration)3, false),
            new Pokemon(512, "AbomasnowMega Abomasnow", "Grass", 90, 132, 105, 132, 105, 30, (PokemonGeneration)3,
                false),
            new Pokemon(513, "Weavile", "Dark", 70, 120, 65, 45, 85, 125, (PokemonGeneration)3, false),
            new Pokemon(514, "Magnezone", "Electric", 70, 70, 115, 130, 90, 60, (PokemonGeneration)3, false),
            new Pokemon(515, "Lickilicky", "Normal", 110, 85, 95, 80, 95, 50, (PokemonGeneration)3, false),
            new Pokemon(516, "Rhyperior", "Ground", 115, 140, 130, 55, 55, 40, (PokemonGeneration)3, false),
            new Pokemon(517, "Tangrowth", "Grass", 100, 100, 125, 110, 50, 50, (PokemonGeneration)3, false),
            new Pokemon(518, "Electivire", "Electric", 75, 123, 67, 95, 85, 95, (PokemonGeneration)3, false),
            new Pokemon(519, "Magmortar", "Fire", 75, 95, 67, 125, 95, 83, (PokemonGeneration)3, false),
            new Pokemon(520, "Togekiss", "Fairy", 85, 50, 95, 120, 115, 80, (PokemonGeneration)3, false),
            new Pokemon(521, "Yanmega", "Bug", 86, 76, 86, 116, 56, 95, (PokemonGeneration)3, false),
            new Pokemon(522, "Leafeon", "Grass", 65, 110, 130, 60, 65, 95, (PokemonGeneration)3, false),
            new Pokemon(523, "Glaceon", "Ice", 65, 60, 110, 130, 95, 65, (PokemonGeneration)3, false),
            new Pokemon(524, "Gliscor", "Ground", 75, 95, 125, 45, 75, 95, (PokemonGeneration)3, false),
            new Pokemon(525, "Mamoswine", "Ice", 110, 130, 80, 70, 60, 80, (PokemonGeneration)3, false),
            new Pokemon(556, "Servine", "Grass", 60, 60, 75, 60, 75, 83, (PokemonGeneration)4, false),
            new Pokemon(557, "Serperior", "Grass", 75, 75, 95, 75, 95, 113, (PokemonGeneration)4, false),
            new Pokemon(558, "Tepig", "Fire", 65, 63, 45, 45, 45, 45, (PokemonGeneration)4, false),
            new Pokemon(559, "Pignite", "Fire", 90, 93, 55, 70, 55, 55, (PokemonGeneration)4, false),
            new Pokemon(560, "Emboar", "Fire", 110, 123, 65, 100, 65, 65, (PokemonGeneration)4, false),
            new Pokemon(561, "Oshawott", "Water", 55, 55, 45, 63, 45, 45, (PokemonGeneration)4, false),
            new Pokemon(562, "Dewott", "Water", 75, 75, 60, 83, 60, 60, (PokemonGeneration)4, false),
            new Pokemon(563, "Samurott", "Water", 95, 100, 85, 108, 70, 70, (PokemonGeneration)4, false),
            new Pokemon(564, "Patrat", "Normal", 45, 55, 39, 35, 39, 42, (PokemonGeneration)4, false),
            new Pokemon(565, "Watchog", "Normal", 60, 85, 69, 60, 69, 77, (PokemonGeneration)4, false),
            new Pokemon(566, "Lillipup", "Normal", 45, 60, 45, 25, 45, 55, (PokemonGeneration)4, false),
            new Pokemon(567, "Herdier", "Normal", 65, 80, 65, 35, 65, 60, (PokemonGeneration)4, false),
            new Pokemon(568, "Stoutland", "Normal", 85, 110, 90, 45, 90, 80, (PokemonGeneration)4, false),
            new Pokemon(569, "Purrloin", "Dark", 41, 50, 37, 50, 37, 66, (PokemonGeneration)4, false),
            new Pokemon(570, "Liepard", "Dark", 64, 88, 50, 88, 50, 106, (PokemonGeneration)4, false),
            new Pokemon(571, "Pansage", "Grass", 50, 53, 48, 53, 48, 64, (PokemonGeneration)4, false),
            new Pokemon(572, "Simisage", "Grass", 75, 98, 63, 98, 63, 101, (PokemonGeneration)4, false),
            new Pokemon(573, "Pansear", "Fire", 50, 53, 48, 53, 48, 64, (PokemonGeneration)4, false),
            new Pokemon(574, "Simisear", "Fire", 75, 98, 63, 98, 63, 101, (PokemonGeneration)4, false),
            new Pokemon(575, "Panpour", "Water", 50, 53, 48, 53, 48, 64, (PokemonGeneration)4, false),
            new Pokemon(576, "Simipour", "Water", 75, 98, 63, 98, 63, 101, (PokemonGeneration)4, false),
            new Pokemon(577, "Munna", "Psychic", 76, 25, 45, 67, 55, 24, (PokemonGeneration)4, false),
            new Pokemon(578, "Musharna", "Psychic", 116, 55, 85, 107, 95, 29, (PokemonGeneration)4, false),
            new Pokemon(579, "Pidove", "Normal", 50, 55, 50, 36, 30, 43, (PokemonGeneration)4, false),
            new Pokemon(580, "Tranquill", "Normal", 62, 77, 62, 50, 42, 65, (PokemonGeneration)4, false),
            new Pokemon(615, "Darumaka", "Fire", 70, 90, 45, 15, 45, 50, (PokemonGeneration)4, false),
            new Pokemon(616, "DarmanitanStandard Mode", "Fire", 105, 140, 55, 30, 55, 95, (PokemonGeneration)4, false),
            new Pokemon(617, "DarmanitanZen Mode", "Fire", 105, 30, 105, 140, 105, 55, (PokemonGeneration)4, false),
            new Pokemon(618, "Maractus", "Grass", 75, 86, 67, 106, 67, 60, (PokemonGeneration)4, false),
            new Pokemon(619, "Dwebble", "Bug", 50, 65, 85, 35, 35, 55, (PokemonGeneration)4, false),
            new Pokemon(746, "Espurr", "Psychic", 62, 48, 54, 63, 60, 68, (PokemonGeneration)5, false),
            new Pokemon(747, "MeowsticMale", "Psychic", 74, 48, 76, 83, 81, 104, (PokemonGeneration)5, false),
            new Pokemon(748, "MeowsticFemale", "Psychic", 74, 48, 76, 83, 81, 104, (PokemonGeneration)5, false),
            new Pokemon(749, "Honedge", "Steel", 45, 80, 100, 35, 37, 28, (PokemonGeneration)5, false),
            new Pokemon(750, "Doublade", "Steel", 59, 110, 150, 45, 49, 35, (PokemonGeneration)5, false),
            new Pokemon(751, "AegislashBlade Forme", "Steel", 60, 150, 50, 150, 50, 60, (PokemonGeneration)5, false),
            new Pokemon(752, "AegislashShield Forme", "Steel", 60, 50, 150, 50, 150, 60, (PokemonGeneration)5, false),
            new Pokemon(753, "Spritzee", "Fairy", 78, 52, 60, 63, 65, 23, (PokemonGeneration)5, false),
            new Pokemon(754, "Aromatisse", "Fairy", 101, 72, 72, 99, 89, 29, (PokemonGeneration)5, false),
            new Pokemon(755, "Swirlix", "Fairy", 62, 48, 66, 59, 57, 49, (PokemonGeneration)5, false),
            new Pokemon(756, "Slurpuff", "Fairy", 82, 80, 86, 85, 75, 72, (PokemonGeneration)5, false),
            new Pokemon(757, "Inkay", "Dark", 53, 54, 53, 37, 46, 45, (PokemonGeneration)5, false),
            new Pokemon(758, "Malamar", "Dark", 86, 92, 88, 68, 75, 73, (PokemonGeneration)5, false),
            new Pokemon(759, "Binacle", "Rock", 42, 52, 67, 39, 56, 50, (PokemonGeneration)5, false),
            new Pokemon(760, "Barbaracle", "Rock", 72, 105, 115, 54, 86, 68, (PokemonGeneration)5, false),
            new Pokemon(761, "Skrelp", "Poison", 50, 60, 60, 60, 60, 30, (PokemonGeneration)5, false),
            new Pokemon(762, "Dragalge", "Poison", 65, 75, 90, 97, 123, 44, (PokemonGeneration)5, false),
            new Pokemon(763, "Clauncher", "Water", 50, 53, 62, 58, 63, 44, (PokemonGeneration)5, false),
            new Pokemon(764, "Clawitzer", "Water", 71, 73, 88, 120, 89, 59, (PokemonGeneration)5, false),
            new Pokemon(765, "Helioptile", "Electric", 44, 38, 33, 61, 43, 70, (PokemonGeneration)5, false),
            new Pokemon(766, "Heliolisk", "Electric", 62, 55, 52, 109, 94, 109, (PokemonGeneration)5, false),
            new Pokemon(767, "Tyrunt", "Rock", 58, 89, 77, 45, 45, 48, (PokemonGeneration)5, false),
            new Pokemon(768, "Tyrantrum", "Rock", 82, 121, 119, 69, 59, 71, (PokemonGeneration)5, false),
            new Pokemon(769, "Amaura", "Rock", 77, 59, 50, 67, 63, 46, (PokemonGeneration)5, false),
            new Pokemon(770, "Aurorus", "Rock", 123, 77, 72, 99, 92, 58, (PokemonGeneration)5, false),
            new Pokemon(771, "Sylveon", "Fairy", 95, 65, 65, 110, 130, 60, (PokemonGeneration)5, false),
            new Pokemon(772, "Hawlucha", "Fighting", 78, 92, 75, 74, 63, 118, (PokemonGeneration)5, false),
            new Pokemon(773, "Dedenne", "Electric", 67, 58, 57, 81, 67, 101, (PokemonGeneration)5, false),
            new Pokemon(774, "Carbink", "Rock", 50, 50, 150, 50, 150, 50, (PokemonGeneration)5, false),
            new Pokemon(775, "Goomy", "Dragon", 45, 50, 35, 55, 75, 40, (PokemonGeneration)5, false),
            new Pokemon(776, "Sliggoo", "Dragon", 68, 75, 53, 83, 113, 60, (PokemonGeneration)5, false),
            new Pokemon(777, "Goodra", "Dragon", 90, 100, 70, 110, 150, 80, (PokemonGeneration)5, false),
        };
}

    public class Pokemon
    {
        public Pokemon(int id, string name, string type, int hp, int attack, int defense, int spAtk, int spDef, int speed, PokemonGeneration generation, bool legendary)
        {
            Id = id;
            Name = name;
            Type = type;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            SpAtk = spAtk;
            SpDef = spDef;
            Speed = speed;
            Generation = generation;
            Legendary = legendary;
        }

        public Pokemon()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }
        public PokemonGeneration Generation { get; set; }
        public bool Legendary { get; set; }
    }

    public enum PokemonGeneration
    {
        I = 0,
        II = 1,
        III = 2,
        IV = 3,
        V = 4,
        VI = 5,
        VII = 6,
        VIII = 7,
        IX = 8
    }
}
