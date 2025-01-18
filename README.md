# KacperKuszek_PatrykKutolowski_2_Inf_NW_nl_2_graRpg
Opis
Jest to gra RPG stworzona w silniku Unity z wykorzystaniem języka C#. Gracz steruje postacią poruszającą się za pomocą strzałek na klawiaturze. Gra umożliwia interakcje z otoczeniem, atakowanie wrogów i rozwijanie postaci poprzez drzewko umiejętności.

Funkcjonalności:
Poruszanie postacią: sterowanie za pomocą strzałek na klawiaturze.
Atakowanie: gracz atakuje naciskając klawisz "K".
Statystyki postaci: naciśnięcie "1" wyświetla aktualne statystyki postaci.
Drzewko umiejętności: naciśnięcie "2" otwiera drzewko umiejętności, pozwalając na rozwój postaci.

Technologie:
Unity – silnik gry.
C# – język programowania użyty do stworzenia skryptów.
Modularna struktura kodu – każdy skrypt odpowiada za pojedynczą funkcjonalność, np. Player_Health, Enemy_Combat, co ułatwia modyfikowanie i rozszerzanie gry.

Sposób gry:
Poruszanie postacią: Używaj strzałek na klawiaturze, aby poruszać postacią po świecie gry.
Atakowanie: Naciśnij klawisz "K", aby zaatakować.
Wyświetlanie statystyk: Naciśnij "1", aby zobaczyć statystyki swojej postaci.
Drzewko umiejętności: Naciśnij "2", aby otworzyć drzewko umiejętności i rozwinąć postać.


Struktura plików:
W projekcie znajdują się skrypty odpowiadające za różne mechaniki gry:
Player_Movement.cs - skrypt odpowiadajacy za poruszanie się gracza. | 
Player_Combat.cs - skrypt odpowiadający za walke gracza. | 
Player_Health.cs – skrypt odpowiadający za zdrowie gracza. | 
Enemy_Movment.cs - skrypt odpowiadajacy za poruszanie sie przeciwnika. | 
Enemy_Combat.cs – skrypt odpowiadający za mechanikę walki przeciwnika. | 
Enemy_Health.cs - skrypt odpowiadajacy za zdrowie przeciwnika. | 
Enemy_Knockback.cs - skrypt odpowiadajacy za odrzut podczas walki. | 
Enemy_Spawner.cs - skrypt odpowadajacy za obiekty w których ma się pojawić przeciwnik. | 
Skill_Manager.cs - skrypt w którym porzątkuje wszystkie mechaniki związane z drzewkiem umiejętności. | 
Skill_Slot.cs - skrypt w którym odbywa się mechanika związana z drzewkiem umiejętności. | 
SkillSO.cs - skrypt który umozliwia stworzenie nowej umiejetności w środowisku unity. | 
SkilltreeManager.cs - skrypt który dysponuje zasobami w UI drzewka umiejetności. | 
ToggleSkillTree.cs - skrypt który pozwala graczowi wyswietlenie UI drzewka. | 

Każdy skrypt jest odpowiedzialny za jedną, wyodrębnioną funkcję, co zapewnia elastyczność i modularność w rozwoju projektu.

Przyszłe plany
Dodanie nowych umiejętności do drzewka umiejętności(bo na razie działa tylko umiejętność związana ze zdrowiem gracza).
Rozbudowa świata gry (nowe przedmioty, przeciwnicy).
Zwiększenie interakcji z otoczeniem (np. NPC, zadania poboczne).

Autorzy
Projekt stworzony przez Kacpra Kuszka i Patryka Kutolowskiego .


