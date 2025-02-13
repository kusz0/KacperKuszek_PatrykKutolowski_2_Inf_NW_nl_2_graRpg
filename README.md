# KacperKuszek_PatrykKutolowski_2_Inf_NW_nl_2_graRpg
(W repozytorium znajdują się tylko skrypty do ocenienia. Całą gre przedsawimy na następnych zajęciach :))

Opis:
Jest to gra RPG stworzona w silniku Unity z wykorzystaniem języka C#. Gracz steruje postacią poruszającą się za pomocą strzałek na klawiaturze. Gra umożliwia interakcje z otoczeniem, atakowanie wrogów i rozwijanie postaci poprzez drzewko umiejętności.

Technologie:
Unity – silnik gry.
C# – język programowania użyty do stworzenia skryptów.
Modularna struktura kodu – każdy skrypt odpowiada za pojedynczą funkcjonalność, np. Player_Health, Enemy_Combat, co ułatwia modyfikowanie i rozszerzanie gry.

Sposób gry:
Poruszanie postacią: Używaj strzałek na klawiaturze, aby poruszać postacią po świecie gry.
Atakowanie: Naciśnij klawisz "K", aby zaatakować.
Wyświetlanie statystyk: Naciśnij "1", aby zobaczyć statystyki swojej postaci.
Drzewko umiejętności: Naciśnij "2", aby otworzyć drzewko umiejętności i rozwinąć postać.

![screenrpg1](https://github.com/user-attachments/assets/85428af7-f741-4a89-9709-17432022f912)
![screenrpg2](https://github.com/user-attachments/assets/3d2752a2-df0d-4066-be38-c3f416b707ea)

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


Przyszłe plany
Dodanie nowych umiejętności do drzewka umiejętności(bo na razie działa tylko umiejętność związana ze zdrowiem gracza).
Rozbudowa świata gry (nowe przedmioty, przeciwnicy).
Zwiększenie interakcji z otoczeniem (np. NPC, zadania poboczne).

Autorzy
Projekt stworzony przez Kacpra Kuszka i Patryka Kutolowskiego . ![screenrpg3](https://github.com/user-attachments/assets/4029a299-7e41-4b1b-9250-00e3948f33b1)

![screenrpg4](https://github.com/user-attachments/assets/1dc44b48-90a4-4d62-be8b-1b638d3aeb6c)


