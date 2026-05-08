# Parameter registry

Every parameter referenced by the calc engine, with its 
canonical units. The Pint registry in 
`chemsteer.calc.units` mirrors this column for unit-safe 
arithmetic.

| ID | Abbr | Name | Units | Notes |
|---:|---|---|---|---|
| 1 | `NS` | Number of Sites | `sites` |  |
| 2 | `OD` | Number of Operating Days | `days/site-yr` |  |
| 3 | `OH` | Operating Hours per Day | `hrs/site-day` |  |
| 4 | `VP` | Vapor Pressure | `torr` |  |
| 5 | `MW` | Molecular Weight | `g/mol` |  |
| 6 | `R` | Universal Gas Constant | `atm cm3/gmol K` |  |
| 7 | `P` | Atmospheric Pressure | `atm` |  |
| 8 | `T` | Temperature | `K` |  |
| 9 | `WFused` | Weight Fraction | `dimensionless` |  |
| 10 | `Yprod` | Weight Fraction of Chemical in Product | `dimensionless` |  |
| 11 | `Yrm` | Weight Fraction of Chemical in Raw Material | `dimensionless` |  |
| 12 | `DMOprod` | Mass Output of Product Containing Chemical | `kg/site-day` |  |
| 13 | `DMOchem` | Daily Mass Output of Chemical in Product | `kg/site-day` |  |
| 14 | `DMIrm` | Mass Input of Raw Material Containing Chemical | `kg/site-day` |  |
| 15 | `DMIchem` | Daily Mass Input of Chemical in Raw Material | `kg/site-day` |  |
| 16 | `Nby` | Total batches/site-year | `btc/site-yr` |  |
| 17 | `Nbd` | Number of Batches per Day | `btc/site-day` |  |
| 18 | `ODmax` | Maximum number of operating days | `days` | feb12 |
| 19 | `Vc` | Volume Capacity of container | `gal/container` |  |
| 20 | `fc` | Fraction of PV to the Container Type | `dimensionless` |  |
| 21 | `vCar` | Volume of paint used per car | `L/car` | mar29 |
| 22 | `f` | Saturation Factor | `dimensionless` |  |
| 23 | `r` | Container Rate | `containers/hr` |  |
| 24 | `Nbld` | Number of batches per line per day | `batches/line` | feb12 |
| 25 | `Ncar` | Number of cars painted per site-day | `cars/site-day` | mar29 |
| 26 | `d` | Diameter of Opening / Pool Length | `cm` |  |
| 27 | `Vpaint` | Volume of paint used per day | `gallons of paint/site-day` | mar29 |
| 28 | `A` | Area | `cm2` |  |
| 29 | `Drm` | Density of the Material in Raw Material | `kg/L` |  |
| 30 | `Dprod` | Density of the Material in Product | `kg/L` |  |
| 31 | `Oha` | Operating Hours for the Activity | `hours/day` |  |
| 32 | `BMOprod` | Batch Mass Output of Product | `kg/site-batch` | feb12 |
| 33 | `BMIChem x Nbd / Ls` | Batch Mass Input of Chemical x Nbd / Ls | `kg/site-day` |  |
| 34 | `HMxChem` | work field | `` | used in Mass Balance |
| 35 | `HD` | work field | `` | used in Mass Balance |
| 36 | `S` | Surface Area | `cm2` | aug25 - constant |
| 37 | `Qu` | Quantity for Chemical on Skin, CB | `mg/cm2-event` | aug25 - no UserDef |
| 38 | `OBSO Ys` | OBSO: Weight Fraction of Chemical in Particulate, Solids Fraction of Mist, or Mixture | `dimensionless` | aug26 - was YsHybrid |
| 39 | `CEB Default` | Internal Work field: 1 | `dimensionless` | Aug28 |
| 40 | `X` | Vapor Pressure Correction Factor | `dimensionless` | mar20 |
| 41 | `EY` | Years of Occupation Exposure | `years` |  |
| 42 | `BW` | Body Weight | `kg` |  |
| 43 | `TE` | Spray Gun Transfer Efficiency | `dimensionless` |  |
| 44 | `b` | Inhalation Rate | `m3/hr` |  |
| 45 | `McE` | Spray Mist Capture Efficiency | `dimensionless` |  |
| 46 | `h` | Exposure Duration | `hrs/day` |  |
| 47 | `AT` | Averaging Time | `years` |  |
| 48 | `ATc` | Averaging Time over a Lifetime (Chronic) | `years` |  |
| 49 | `G` | Vapor Generation Rate | `g/s` | input |
| 50 | `G` | Vapor Generation Rate | `g/s` | output |
| 51 | `k` | Mixing Factor | `dimensionless` |  |
| 52 | `SrE` | Solid Removal Efficiency from Captured Mist | `dimensionless` |  |
| 53 | `Q` | Ventilation Rate | `ft3/min` |  |
| 54 | `CmCvOption` | FOR INTERNAL USE ONLY: Cm/Cv option | `` |  |
| 55 | `S` | Surface Area | `cm2` |  |
| 56 | `Qu` | Quantity for Chemical on Skin, CB | `mg/cm2-event` |  |
| 57 | `KCk` | Mass concentration of total or total respirable particulate in air | `mg/m3` | july14, w/o user defined |
| 58 | `SQu` | Surface Area x Quantity for Chemical on Skin | `mg/event` |  |
| 59 | `Ymist` | Weight fraction of chemical in mist | `dimensionless` | july14 |
| 60 | `FT` | Frequency of Events | `events/site-day` |  |
| 61 | `AH` | Amount of Material Handled | `kg/day` |  |
| 62 | `KCk` | Mass concentration of total or total respirable particulate in air | `mg/m3` | w/user defined |
| 63 | `Vm` | Molar Volume | `L/mol` |  |
| 64 | `Cm` | Mass Concentration of Chemical in Air | `mg/m3` | input, special processing in Rel Model View/Update |
| 65 | `Cm` | Mass Concentration of Chemical in Air | `mg/m3` | output |
| 66 | `Cv` | Volume Concentration of Chemical in Air | `ppm` | output |
| 67 | `Cv` | Volume Concentration of Chemical in Air | `ppm` | input, special processing in Rel Model View/Update |
| 68 | `Ysf` | Weight fraction of solids in paint | `dimensionless` | July14 |
| 69 | `vz` | Air Speed | `ft/min` |  |
| 70 | `KCk` | Mass concentration of total or total respirable particulate in air | `mg/m3` | aug24 |
| 71 | `h` | Exposure Duration | `hrs/day` | aug24 |
| 72 | `Freq` | Frequency to Use | `days/site-yr` | Label EF on Exp |
| 73 | `LF` | Loss Fraction | `dimensionless` | no user defined |
| 74 | `LF` | Loss Fraction | `dimensionless` | autos, 1-TE |
| 75 | `ED` | Exposure Days | `days/site-yr` | 4/3 |
| 76 | `Yl` | Weight Fraction in liquid | `dimensionless` | 4/3 |
| 77 | `Yderm` | Weight Fraction of chemical in liquid/solid | `dimensionless` | 4/5 |
| 78 | `Ys` | Weight Fraction of Chemical in Particulate, Solids Fraction of Mist, or Mixture | `dimensionless` | 4/3 - meta |
| 79 | `CF` | Correction Factor | `dimensionless` | added apr29 |
| 80 | `WSchem` | Water solubility of the chemical | `g/L` | added apr29 |
| 81 | `EF` | Exposure Factor | `mg/kg` | 4/29 |
| 82 | `Sd` | Shifts worked by the worker | `shifts/worker/day` | 4/29 |
| 83 | `BMIrm x Nbd` | Batch Mass Input of Raw Material x Nbd | `kg/site-day` | Apr29 |
| 84 | `BMIrm x Nbd / Ls` | Batch Mass Input of Raw Material x Nbd / Ls | `kg/site-batch` | Apr29 |
| 85 | `BMOprod x Nbd` | Batch Mass Output of Product x Nbd | `kg/site-day` | Apr29 |
| 86 | `BMOprod x Nbd / Ls` | Batch Mass Output of Product x Nbd / Ls | `kg/site-batch` | Apr29 |
| 87 | `MCi x Ncd` | Mass Capacity of container x Ncd | `kg/container` | Apr29 |
| 88 | `BMIrm x Ls` | Batch Mass Input of Raw Material x Ls | `kg/site-batch` | Apr29 |
| 89 | `BMOprod x Ls` | Batch Mass Output of Product x Ls | `kg/site-batch` | Apr29 |
| 90 | `Cvk` | Vapor concentration of the chemical | `ppm` | 5/1 |
| 91 | `NWexp` | Number of Workers Exposed | `workers/site` |  |
| 92 | `Amt` | Amount to Use | `kg/site-day` |  |
| 93 | `ODa` | Days per site per year for the activity | `days/yr` | mar20 |
| 94 | `Yi` | Weight fraction of chemical in material handled | `dimensionless` | apr03 |
| 95 | `VPpel` | Vapor Pressure of the pure PEL chemical | `torr` | 5/1 |
| 96 | `Ypel` | Weight fraction of chemical with PEL in mixture | `dimensionless` | 5/1 |
| 97 | `MWpel` | Molecular weight of the PEL chemical | `g/mol` | 5/1 |
| 98 | `CEB Default` | Internal Work field: 250 | `days/site-yr` | 5/1 |
| 99 | `BMIrm` | Batch Mass Input of Raw Material | `kg/site-batch` | feb12 |
| 100 | `Di` | Density of material handled in activity | `kg/L` |  |
| 101 | `HB` | Hours per batch | `hours` | feb12 |
| 102 | `Ls` | Lines per site | `lines/site` | feb12 |
| 103 | `BMIchem` | Batch Mass Input of Chemical | `kg/site-batch` | feb12 |
| 104 | `BMOchem` | Batch Mass Output of Chemical | `kg/site-batch` | feb12 |
| 105 | `Ncy` | Number of Containers per site per year | `containers/site-year` | mar20 |
| 106 | `BMOchem x Nbd` | Batch Mass Output of Chemical x Nbd | `kg/site-day` | mar23 |
| 107 | `BMIchem x Nbd` | Batch Mass Input of Chemical x Nbd | `kg/site-day` | mar23 |
| 108 | `BMOchem x Ls` | Batch Mass Output of Chemical x Ls | `kg/site-batch` | mar23 |
| 109 | `BMIchem x Ls` | Batch Mass Input of Chemical x Ls | `kg/site-batch` | mar23 |
| 110 | `MCi` | Mass Capacity of container | `kg/container` | mar23 |
| 111 | `MCi x Yi` | Mass Capacity of container x Yi | `kg/container` | mar23 |
| 112 | `MCi x Yi x Ncd` | Mass Capacity of container x Yi x Ncd | `kg/container` | mar23 |
| 113 | `Ys` | Weight Fraction of Chemical in Particulate, Solids Fraction of Mist, or Mixture | `dimensionless` | aug26 - nonMeta |
| 114 | `AMOprod` | Annual Mass of Adhesive Formulated containing the chemical | `kg/site-year` | july26 |
| 115 | `Vbatch` | Volume of Adhesive Formulated per batch | `liters/batch` | july26 |
| 116 | `DVIppaint` | Volume of purchased paint used per day | `Liters/site-day` | Aug10 |
| 117 | `LF` | Loss Fraction | `dimensionless` | user defined |
| 118 | `Xrm` | Vapor Pressure Correction Factor for Raw Material | `dimensionless` | May12 |
| 119 | `Xprod` | Vapor Pressure Correction Factor for Product | `dimensionless` | May12 |
| 120 | `Xother` | Vapor Pressure Correction Factor for Other Material | `dimensionless` | May12 |
| 121 | `AVPrm` | Adjusted Vapor Pressure for Raw Material | `torr` | May12 |
| 122 | `AVPprod` | Adjusted Vapor Pressure for Product | `torr` | May12 |
| 123 | `BMOChem x Nbd / Ls` | Batch Mass Output of Chemical x Nbd / Ls | `kg/site-day` |  |
| 124 | `Yctw` | Weight fraction of the chemical in the cooling tower | `dimensionless` | oct02 - robyn |
| 125 | `Dctw` | Density of the recirculating cooling tower water | `kg/gal` | oct02 - robyn |
| 126 | `RRctw` | Recirculation rate of the cooling tower operation | `hrs/site-day` | oct02 - robyn |
| 127 | `LFb` | Loss fraction of daily recirculation rate from cooling tower blowdown | `dimensionless` | oct02 - robyn |
| 128 | `LFw` | Loss fraction of daily recirculation rate from cooling tower windage | `dimensionless` | oct02 - robyn |
| 129 | `Lfe` | Loss fraction of daily recirculation rate from cooling tower evaporation | `dimensionless` | oct02 - robyn |
| 130 | `DRRchem` | Daily recirculation rate of chemical in the cooling tower | `kg/site-day` | oct02 - robyn |
| 131 | `Ybath` | Weight fraction of the chemical in the bath | `dimensionless` | jul04 - robyn |
| 132 | `Yrinse` | Weight fraction of the chemical in the rinse water | `dimensionless` | jul04 - robyn |
| 133 | `Dbath` | Density of the bath | `kg/liter` | jul04 - robyn |
| 134 | `Drinse` | Density of the rinse | `kg/liter` | jul04 - robyn |
| 135 | `Vbath` | Volume of solution per bath | `gallons/bath` | jul04 - robyn |
| 136 | `Nbath` | Number of bath tanks per site | `baths/site` | jul04 - robyn |
| 137 | `Freqbath` | Frequency of bath changes per year | `changes/bath/yr` | jul04 - robyn |
| 138 | `DVrinse` | Daily volume of rinse water generated per site | `gallons/site-day` | jul04 - robyn |
| 139 | `RinseE` | Rinsewater recovery efficiency | `dimensionless` | jul04 - robyn |
| 140 | `EPVop` | Estimated PVop for iterative calculation sequences | `need uinit` | jul04 - robyn |
| 141 | `DVbath` | Daily volume of bath change | `gallons` | jul04 - robyn |
| 142 | `WWTE` | Wastewater treatment efficiency | `dimensionless` | jul04 - robyn |
| 143 | `DstCntrl` | Dust control technology | `` | july07 - jc |
| 144 | `SrE` | Solid removal efficiency of dust control technology | `dimensionless` | july07 - jc |
| 145 | `VFF` | Volume of Far-Field | `m3` | Nov14 - rr |
| 146 | `AER` | Air Exchange Rate | ` 1/hr` | Nov14 - rr |
| 147 | `velocityNF` | Near-Field indoor wind speed | `m/hr` | Nov14 - rr |
| 148 | `LNF` | Length of Near-Field | `m` | Nov14 - rr |
| 149 | `WNF` | Width of Near-Field | `m` | Nov14 - rr |
| 150 | `HNF` | Height of Near-Field | `m` | Nov14 - rr |
| 151 | `G` | Vapor Generation Rate | `mg/hr` | Nov14 - rr |
| 152 | `I` | Inhalation potential dose rate | `mg/day` | Nov14 - rr |
| 153 | `CnfTWA` | Mass concentration of chemical in near-field air | `mg/m3` | Nov14 - rr |
| 154 | `CffTWA` | Mass concentration of chemical in far-field air | `mg/m3` | Nov14 - rr |
| 155 | `LADD` | Lifetime average daily dose | `mg/kg-day` | Nov14 - rr |
| 156 | `ADD` | Average daily dose | `mg/kg-day` | Nov14 - rr |
| 157 | `APDR` | Acute potential dose rate | `mg/kg-day` | Nov14 - rr |
| 158 | `VNF` | Volume of Near-Field | `volume` | Nov14 - rr |
| 159 | `FSA` | Free Surface Area | `m2` | Nov14 - rr |
| 160 | `QNF` | Near-Field Ventilation Rate | `m3/hr` | Nov14 - rr |
| 161 | `QFF` | Far-Field Ventilation Rate | `m3/hr` | Nov14 - rr |