# 🧠 Panoramica del progetto CoViD

## 🔬 Obiettivo  
Simulare la diffusione di una epidemia (CoViD-19) con un modello computazionale **alternativo al classico SIR**, evitando le equazioni differenziali e puntando su una rappresentazione più realistica e dinamica.

## 🛠️ Linguaggio e ambiente  
- Sviluppato in **C#**  
- Applicazione **desktop** con interfaccia grafica  
- Creato con **Visual Studio Community 2019**

## 📌 Caratteristiche principali  
Modello computazionale basato sulla
- simulazione di una **regione** (area geografica, territorio) popolata da **persone** che si muovono e interagiscono tra loro e con il territorio  
- nel modello ci sono normali **entità** come scuole, ospedali e uffici   
- La malattia si propaga tramite contaminazione dinamica di **aree** e **individui**  
- le persone si contagiano tra loro o contaminano territori (starnutiscono, toccano) che poi contagiono altre persone propagando la malattia

## 📈 Diagrammi rappresentativi
I due diagrammi principali rappresentano:
- a sx sono le persone che si muovono sul territorio il colore rappresenta il loro stato di salute
- a dx è lo stato di contaminazione del territorio dove le persone si muovono e vivono.

Diagrammi secondari (evolutivi)
- **SIR** l'evoluzione del fenomeno rappresentato con i due diagrammi principale, rappresentato con i parametri SIR 
- **Delta SIR** rappresentazione dello scostamento dei due modelli (evidenza della differenza tra quello che dice il modello SIR e ciò che avviene 'realmente')
- **contaminazione** diagramma della evoluzione della estensione delle zone contaminate
- **performance** indicazione del costo computazionale  

## ⚙️Configurazione
- Parametrizzazione avanzata: isolamento, distribuzione, durata, ecc.  
- Interfaccia grafica con **tooltip**, **snapshots**, e **controlli interattivi**

## 📊 Critica al modello SIR  
- Approccio troppo semplificato e non lineare  
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


