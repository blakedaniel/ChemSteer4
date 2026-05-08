# Model registry

Every release / inhalation / dermal model that ships in the v3.2 
seed data, with its equation as ChemSTEER stores it. 
Equations are reproduced verbatim from `ListOfModels.Equation`.

## Release models

### #1 — EPA/OPPT Bulk Transport Residual Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Bulk Transport Residual Model, CEB standard 0.2% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #2 — EPA/OPPT Drum Residual Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Drum Residual Model, CEB standard 3% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #3 — EPA/OPPT Multiple Process Vessel Residual Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Multiple Process Vessel Residual Model, CEB standard 2% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #4 — EPA/OPPT Single Process Vessel Residual Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Single Vessel Residual Model, CEB standard 1% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #5 — EPA/OPPT Small Container Residual Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Small Container Residual Model, CEB standard 0.6% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #6 — EPA/OPPT Solid Residuals in Transport Containers Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Solid Residuals in Transport Containers Model, CEB standard 1% residual.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #7 — EPA/OAQPS AP-42 Loading Model

**Mechanism:** Displacement of air containing chemical vapor

**Basis:** EPA/OAQPS AP-42 Loading Model.

**Equation:**

```
DR (kg/site-day) = (G × 3600 × OHa) / 1000
DR occurs over [Freq] days/year
G (g/s) = f × MW × (Vc x 3785.4) × r × X × (VP / 760) / (3600 × T × R)
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #8 — EPA/OPPT Mass Transfer Coefficient Model

**Mechanism:** Volatilization of chemical from "static" pool

**Basis:** EPA/OPPT Mass Transfer Coefficient Model.

**Equation:**

```
DR (kg/site-day) = (G × 3600 × OHa) / 1000
DR occurs over [Freq] days/year
G (g/s) = 1.93x10-7 x MW0.78 x X x VP x (1/29 + 1/MW)0.33 x vz0.78 x A / (T0.4 x d0.11 x (T0.5 - 5.87)2/3)
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #9 — EPA/OPPT Penetration Model

**Mechanism:** Volatilization of chemical from "static" pool

**Basis:** EPA/OPPT Penetration Model.

**Equation:**

```
DR (kg/site-day) = (G × 3600 × OHa) / 1000
DR occurs over [Freq] days/year
G (g/s) = 8.24x10-8 x MW0.835 x X x VP x (1/29 + 1/MW)0.25 x vz0.5 x A / (T0.05 x d0.5 x P0.5)
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #12 — EPA/OPPT Cooling Tower Blowdown Loss Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Cooling Tower Blowdown Loss Model; up to 0.6% of the tower recirculation rate.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #13 — EPA/OPPT Cooling Tower Windage Loss Model

**Mechanism:** Not applicable

**Basis:** EPA/OPT Cooling Tower Windage Loss Model; up to 0.1% of the tower recirculation rate.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #14 — EPA/OPPT Cooling Tower Evaporative Loss Model (volatiles)

**Mechanism:** Not applicable

**Basis:** EPA/OPT Cooling Tower Evaporative Loss Model (volatiles); user specified fraction of the tower recirculation rate.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #39 — User-Defined Loss Rate Model

**Mechanism:** Not applicable

**Basis:** User-Defined Loss Rate Model.

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #41 — EPA/OPPT Automobile Refinish Coating Overspray Loss Model (non-volatiles)

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Automobile Refinish Coating Overspray Loss Model (non-volatiles).

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #42 — EPA/OPPT Water Saturation Loss Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Water Saturation Loss Model.

**Equation:**

```
DR (kg/site-day) = WSchem × CF × Amt / 1000
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #43 — User-defined Vapor Generation Rate Model

**Mechanism:** The user enters the vapor generation rate and associated parameters.

**Basis:** User-defined Vapor Generation Rate Model.

**Equation:**

```
DR (kg/site-day) = (G × 3600 × OHa) / 1000
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #48 — EPA/OPPT Automobile OEM Coating Overspray Loss Model (non-volatiles)

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Automobile OEM Coating Overspray Loss Model (non-volatiles).

**Equation:**

```
DR (kg/site-day) = LF × Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

### #51 — EPA/OPPT Electroplating Spent Bath Disposal Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Electroplating Spent Bath Disposal Model

**Equation:**

```
DR (kg/site-day) = (DVbath × 3.78L/gal × Ybath × Dbath
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS, AR is for all sites combined
```

### #52 — EPA/OPPT Electroplating Rinse Water Loss Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Electroplating Rinse Water Loss Model

**Equation:**

```
DR (kg/site-day) = DVrinse × 3.78L/gal × Yrinse × Drinse × (1 - RinseE)
```

### #53 — EPA/OPPT Solids Transfer Dust Loss Model

**Mechanism:** Not applicable

**Basis:** EPA/OPPT Solids Transfer Dust Loss Model. No dust controls are assumed as a worst case.

**Equation:**

```
DR (kg/site-day) = LF x Amt
DR occurs over [Freq] days/year
AR (kg/year) = DR × Freq × NS,  AR is for all sites combined
```

## Inhalation models

### #18 — UV Roll Coating Inhalation Model

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** EPA/OPPT UV Roll Coating Inhalation Model (non-volatiles); airborned particulate concentration (KcK is based on 8-hour TWA personal monitoring data.

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #21 — EPA Small Volume Handling Model

**Mechanism:** Inhalation / Particulate

**Basis:** EPA Small Volume Handling Model, less than 54 kg of solid containing the PMN handled per site-day.

**Equation:**

```
I = EF x AH x Ys x Sd
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #22 — EPA/OPPT Mass Balance Model

**Mechanism:** Inhalation / Vapor

**Basis:** EPA/OPPT Mass Balance Model.

**Equation:**

```
I = Cm x b x h
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
Cm = Cv x MW / Vm
Cv = lesser of (170,000 x T x G) / (MW x Q x k) or 1,000,000 x X x VP / 760
NW = NWexp x NS
```

### #23 — OSHA PEL-Limiting Model for Substance-specific Particulates (TWA or C)

**Mechanism:** Inhalation / Particulate

**Basis:** OSHA PEL-Limiting Model for Substance-specific Particulates (TWA or C).

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys / Ypel
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR = I / BW
NW = NWexp x NS
```

### #24 — OSHA Total PNOR PEL-Limiting Model

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** OSHA PNOR PEL-Limiting Model.

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #40 — EPA/OPPT Automobile Spray Coating Inhalation Exposure Model (polyisocyanates)

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** EPA/OPPT Automobile Spray Coating Inhalation Model (non-volatile polyisocyanates).

**Equation:**

```
I = Cm x b x h
Cm = KCk
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #45 — OSHA PEL-Limiting Model for Substance-specific Vapor (TWA or C)

**Mechanism:** Inhalation / Vapor

**Basis:** OSHA PEL-Limiting Model for Substance-specific Vapor (TWA or C)

**Equation:**

```
I = Cm x b x h
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
Cm = Cv x MW / Vm
Cv = lesser of Cvk x (VP x Ys / MW) / (Vppel x Ypel / Mwpel) or 1,000,000 x X x VP / 760
NW = NWexp x NS
```

### #46 — User-defined Inhalation Model

**Mechanism:** Inhalation / Vapor, particulate, mist, aerosols, etc.

**Basis:** User-defined Inhalation Model.

**Equation:**

```
Cm = Cv x MW / Vm x Ys 
I = Cm x b x h
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #47 — OSHA Respirable PNOR PEL-Limiting Model

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** OSHA Respirable PNOR PEL-Limiting Model.

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #49 — EPA/OPPT Automobile OEM Spray Coating Inhalation Exposure Model (non-volatile non-polyisocyanates)

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** EPA/OPPT Automobile OEM Spray Coating Inhalation Model (non-volatile non-polyisocyanates).

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #50 — EPA/ OPPT Refinish Automobile Spray Coating Inhalation Exposure Model (non-volatiles)

**Mechanism:** Inhalation / Particulate or non-volatile portion of mist, aerosols, etc.

**Basis:** EPA/ OPPT Automobile Refinish Spray Coating Inhalation Model (non-volatile non-polyisocyanates).

**Equation:**

```
I = Cm x b x h
Cm = KCk x Ys
LADD = (I x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (I x ED x Y) / (BW x AT x 365 days/yr)
APDR =  I / BW
NW = NWexp x NS
```

### #54 — EPA/OPPT Near-Field/Far-Field Inhalation Exposure Model

**Mechanism:** Inhalation / Vapor

**Basis:** EPA/OPPT Near-Field/Far-Field Inhalation Exposure Model

**Equation:**

```
I = Cm x b x h
Cnf: Cm Near Field = ((G x 3600000 x (k1 x h + k2 x EXP(lambda1 x h) / lambda1 - k3 x EXP(lambda2 x h) / lambda2)) - (G x 3600000 x k2 / lambda1 - k3 / lambda2)) / h
Cff: Cm Far Field) = ((G x 3600000 x (h / QFF + k4 x EXP(lambda1 x h) / lambda1 - k5 x EXP(lambda2 x h) / lambda2)) - (G x 3600000 x k4 / lambda1 - k5 / lambda2)) / h 
NW = NWexp x NS
LADD = (I × ED × EY) / (BW × ATc × 365 days / yr)
ADD = (I × ED × EY) / (BW × AT × 365 days / yr)
APDR = I / BW 
VNF = LNF x WNF x HNF
FSA = 2 x (LNF x HNF) + 2 x (WNF x HNF) + (LNF x WNF)
QNF = 0.5 x FSA x velocityNF
QFF = VFF x AER
k1 = 1 / ((QNF / (QNF + QFF))  x QFF)
k2 = (QNF x QFF + lambda2 x VNF x (QNF + QFF)) / (QNF x QFF x VNF x (lambda1 - lambda2))
k3 = (QNF x QFF + lambda1 x VNF x (QNF + QFF)) / (QNF x QFF x VNF x (lambda1 - lambda2))
k4 = ((lambda1 x VNF + QNF) / QNF) x k2
k5 = ((lambda2 x VNF + QNF) / QNF) x k3
lambda1 = 0.5 x (-Y + ((Y^2)  - Z)^0.5)
lambda2 = 0.5 x (-Y - ((Y^2)  - Z)^0.5)
Y = (QNF x VFF + VNF x (QNF + QFF)) / (VNF x VFF)
Z = 4 x QNF x QFF / VNF / VF
```

## Dermal models

### #25 — EPA/OPPT 1-Hand Dermal Contact with Liquids Model

**Mechanism:** Dermal contact / Liquid

**Basis:** EPA/OPPT 1-Hand Dermal Contact with Liquids Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```

### #26 — EPA/OPPT 2-Hand Dermal Contact with Liquid Model

**Mechanism:** Dermal contact / Liquid

**Basis:** EPA/OPPT 2-Hand Dermal Contact with Liquids Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```

### #27 — EPA/OPPT 2-Hand Dermal Immersion in Liquid Model

**Mechanism:** Dermal contact / Liquid

**Basis:** EPA/OPPT 2-Hand Dermal Immersion in Liquid Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```

### #28 — EPA/OPPT Direct 2-Hand Dermal Contact with Solids Model

**Mechanism:** Dermal contact / Solid

**Basis:** EPA/OPPT Direct 2-Hand Dermal Contact with Solids Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```

### #29 — EPA/OPPT 2-Hand Dermal Contact with Container Surfaces (Solids) Model

**Mechanism:** Dermal contact / Solid

**Basis:** EPA/OPPT 2-Hand Dermal Contact with Container Surfaces (Solids) Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```

### #44 — User-defined Dermal Model

**Mechanism:** Dermal contact / Liquid or solid

**Basis:** User-defined Dermal Model.

**Equation:**

```
Dexp = S x Qu x Wf x FT
LADD = (Dexp x ED x Y) / (BW x ATc x 365 days/yr)
ADD = (Dexp x ED x Y) / (BW x AT x 365 days/yr)
APDR = Dexp / BW
NW = NWexp x NS
```
