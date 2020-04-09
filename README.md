# Algorytm-Genetyczny

Zadanie.
Znaleźć w przedziale <-4; 12> argument z dokładnością 0,001, dla którego funkcja:
F(x)= x MOD 1 * (COS( 20 * π * x) – SIN(x)) przyjmuje maksimum.

Dokonać implementacji szkieletu Algorytmu Genetycznego:
Dane do implementacji:
Konfiguracja początkowa – parametry:
1. Przedział rozwiązań: [a, b]
2. Dokładność rozwiązania: d
3. Rozmiar populacji: N
4. Liczba pokoleń: T
5. Prawdopodobieństwo krzyżowania: pk[0; 1], ! zwykle stosowane: pk(0.5; 1)
6. Prawdopodobieństwo mutacji: pm[0; 1], ! zwykle stosowane: pm(0; 0.01)

Moduły:
1. Kodowanie osobnika
2. Losowa inicjalizacja populacji początkowej P(t)
3. Ocena osobników w populacji P(t) (funkcja oceny + funkcja dopasowania)
4. Selekcja osobników (otrzymujemy pokolenie po selekcji)
5. Wybór rodziców przy udziale parametru prawdopodobieństwa krzyżowania (otrzymujemy
pokolenie przejściowe - pokolenie rodziców, osobników zdolnych wydać potomstwo)
6. Krzyżowanie rodziców (otrzymujemy pokolenie osobników potomnych)
7. Mutacja osobników potomnych w oparciu o parametr prawdopodobieństwa mutacji
(otrzymujemy nowe pokolenie)
8. Tworzący dokumentację przebiegu Algorytmu Genetycznego (wypisuje pokolenia -
osobniki + wartości funkcji oceny)
9. Podsumowujący wyniki działania Algorytmu Genetycznego (wypisuje: minimalną, średnią
i maksymalną wartość funkcji oceny w każdym pokoleniu oraz tworzy wykres na ich
podstawie)
