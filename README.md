# KacperKuszek_PatrykKutolowski_2_Inf_NW_nl_2_graRpg
(W repozytorium znajdują się tylko skrypty do ocenienia. Całą gre przedsawimy na następnych zajęciach :))

1.Opis:
Jest to gra RPG stworzona w silniku Unity z wykorzystaniem języka C#. Gracz steruje postacią poruszającą się za pomocą strzałek na klawiaturze. Gra umożliwia interakcje z otoczeniem, atakowanie wrogów i rozwijanie postaci poprzez drzewko umiejętności.

2.Technologie:
Unity – silnik gry.
C# – język programowania użyty do stworzenia skryptów.
Modularna struktura kodu – każdy skrypt odpowiada za pojedynczą funkcjonalność, np. Player_Health, Enemy_Combat, co ułatwia modyfikowanie i rozszerzanie gry.

3.Sposób gry:
Poruszanie postacią: Używaj strzałek na klawiaturze, aby poruszać postacią po świecie gry.
Atakowanie: Naciśnij klawisz "K", aby zaatakować.
Wyświetlanie statystyk: Naciśnij "1", aby zobaczyć statystyki swojej postaci.
Drzewko umiejętności: Naciśnij "2", aby otworzyć drzewko umiejętności i rozwinąć postać.

![screenrpg1](https://github.com/user-attachments/assets/85428af7-f741-4a89-9709-17432022f912)
![screenrpg2](https://github.com/user-attachments/assets/3d2752a2-df0d-4066-be38-c3f416b707ea)

4.Struktura plików:
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


5.Przyszłe plany

Dodanie nowych umiejętności do drzewka umiejętności(bo na razie działa tylko umiejętność związana ze zdrowiem gracza).
Rozbudowa świata gry (nowe przedmioty, przeciwnicy).
Zwiększenie interakcji z otoczeniem (np. NPC, zadania poboczne).


6.Architektura

a)DZIEDZICZENIE:
Dziedziczenie jest jednym z fundamentów architektury projektu i przejawia się w dwóch głównych aspektach:
Dziedziczenie po MonoBehaviour:
Wszystkie klasy odpowiedzialne za funkcjonalność gry, takie jak PlayerHealth, EnemyMovement, SkillTreeManager, czy StatsManager, dziedziczą po MonoBehaviour.
Dzięki temu klasy te:
Mogą być przypisywane jako komponenty do obiektów w scenie.
Zyskują dostęp do wbudowanych metod cyklu życia obiektów w Unity, takich jak Start(), Update(), OnDrawGizmosSelected(), itd.
Integrują się z silnikiem Unity w celu reagowania na zdarzenia w grze.
Dziedziczenie specjalizowanych elementów:
W grze występują pewne przypadki implementacji interakcji między różnymi klasami za pomocą wspólnych interfejsów i delegatów. Choć pełne hierarchiczne dziedziczenie klas nie jest szeroko wykorzystywane (np. brak głębokiej hierarchii), MonoBehaviour zastępuje w tym projekcie rolę klasy bazowej.

b)POLIMORFIZM:
Polimorfizm jest realizowany głównie w kontekście:

I)Dynamiczne wywoływanie zdarzeń:
Klasy, takie jak SkillSlot, wykorzystują zdarzenia (OnAbilityPointSpent, OnSkillMaxed) i pozwalają na różnorodne reakcje obiektów, które nasłuchują tych zdarzeń. Dzięki temu różne komponenty mogą reagować na wspólne zdarzenie w zróżnicowany sposób.
Przykład:

II)Różnorodność zachowań:
Klasy takie jak EnemyMovement czy PlayerMovment2 nadpisują wbudowane metody, takie jak Update() czy FixedUpdate(), implementując własne zachowania:
EnemyMovement obsługuje ściganie gracza i atakowanie.
PlayerMovment2 odpowiada za poruszanie się gracza z uwzględnieniem fizyki.

III)Polimorfizm w logice ataków:
Zarówno Player_Combat, jak i Enemy_Combat używają tej samej logiki opartej na wykrywaniu kolizji (metoda Physics2D.OverlapCircleAll) dla ataków. Dzięki temu mechanizm ataku jest zunifikowany, ale konkretne zachowania mogą się różnić w zależności od klasy.

c)HERMETYZACJA:
Hermetyzacja w projekcie przejawia się poprzez:

I)Enkapsulację danych:
Kluczowe zmienne w klasach, takie jak currentHealth czy maxHealth w PlayerHealth i Enemy_Health, są zarządzane wewnątrz klasy, a dostęp do nich odbywa się przez metody takie jak ChangeHealth().
Hermetyzacja logiki zarządzania umiejętnościami:
Klasa SkillSlot hermetyzuje szczegóły dotyczące odblokowywania i ulepszania umiejętności. Informacje o tym, czy umiejętność jest dostępna, oraz aktualny poziom są ukryte przed innymi klasami, a dostęp odbywa się za pomocą odpowiednich metod:
Unlock()
TryUpgradeSkill()
CanUnlockSkill()
Biblioteki i Interfejsy
d)Biblioteki:
Unity Engine API jest podstawową biblioteką używaną w projekcie.
Dodatkowo wykorzystywane są komponenty takie jak:
Rigidbody2D do obsługi fizyki.
Animator do obsługi animacji.
TMP_Text z TextMesh Pro do zaawansowanego wyświetlania tekstu w grze.

e)INTERFEJSY:
Choć nie zostały bezpośrednio zaimplementowane w kodzie, logika zdarzeń w klasach takich jak SkillSlot czy Enemy_Health spełnia podobną rolę, umożliwiając odseparowanie źródła zdarzeń od ich obsługi.

f)CYKL ZYCIA W UNITY:
Dziedziczenie po MonoBehaviour zapewnia klasom pełną integrację z cyklem życia Unity. Dzięki temu każda klasa:
Może inicjalizować dane w Start() lub Awake().
Obsługiwać zdarzenia na bieżąco w Update().
Wykonywać operacje związane z fizyką w FixedUpdate().

7.Autorzy
Projekt stworzony przez Kacpra Kuszka i Patryka Kutolowskiego . ![screenrpg3](https://github.com/user-attachments/assets/4029a299-7e41-4b1b-9250-00e3948f33b1)

![screenrpg4](https://github.com/user-attachments/assets/1dc44b48-90a4-4d62-be8b-1b638d3aeb6c)


