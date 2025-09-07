# 🧠 Panoramica del progetto CoViD

## 🔬 Obiettivo  
Simulare la diffusione di un’epidemia (CoViD-19) con un modello computazionale **alternativo al classico SIR**, evitando le equazioni differenziali e puntando su una rappresentazione più realistica e dinamica.

## 🛠️ Linguaggio e ambiente  
- Sviluppato in **C#**  
- Applicazione **desktop** con interfaccia grafica  
- Creato con **Visual Studio Community 2019**

## 📌 Caratteristiche principali  
Modello computazionale basato su:
- Simulazione di una **regione** (area geografica, territorio) popolata da **persone** che si muovono e interagiscono tra loro e con l’ambiente circostante  
- Presenza di **entità** come scuole, ospedali e uffici  
- Propagazione della malattia tramite contaminazione dinamica di **aree** e **individui**  
- Le persone si contagiano tra loro o contaminano il territorio (tossiscono, starnutiscono, toccano), che a sua volta può contagiare altri individui

## 📈 Diagrammi rappresentativi  
I due diagrammi principali rappresentano:
- A sinistra: le persone che si muovono sul territorio; il colore indica il loro stato di salute  
- A destra: lo stato di contaminazione del territorio in cui le persone vivono e si muovono

Diagrammi secondari (evolutivi):
- **SIR**: evoluzione del fenomeno rappresentata con i parametri SIR  
- **Delta SIR**: scostamento tra il modello SIR e ciò che avviene “realmente” nella simulazione  
- **Contaminazione**: evoluzione dell’estensione delle zone contaminate  
- **Performance**: indicazione del costo computazionale

## ⚙️ Configurazione  
- Parametrizzazione avanzata: isolamento, distribuzione, durata, ecc.  
- Interfaccia grafica con **tooltip**, **snapshots** e **controlli interattivi**

## 📊 Critica al modello SIR  
- Approccio troppo semplificato e lineare  
- Ignora il tempo reale e le onde epidemiche  
- Non rappresenta la complessità del contagio in ambienti dinamici

## 📈 Risultati notevoli  
- La diffusione dipende più dalla **topologia** che dalle caratteristiche del virus  
- Possibilità di calcolare dinamicamente **β** e **γ** (parametri SIR) e mostrarne la variabilità  
- Visualizzazione intuitiva dell’impatto delle misure di contenimento

## 🌍 Applicazioni  
- Strumento didattico per **scuole** e **università**  
- Supporto alla **ricerca epidemiologica**  
- Base per sviluppi futuri in ambito **sanitario**, **urbanistico** o **sociale**

## 📂 Codice sorgente  
Il progetto è open source e disponibile su GitHub:  
👉 [https://github.com/coGit-ergo-sum/CoViD](https://github.com/coGit-ergo-sum/CoViD)
