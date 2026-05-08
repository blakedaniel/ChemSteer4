# Model-selection decision tree

ChemSTEER's model-selection logic is encoded as **data**, not as 
compiled branching. The tree below is rendered directly from 
`ChmSteer.epa::ListOfActivities` joined with `ListOfValidModels` 
and `ListOfModels`.

Negative `Default*Model` IDs are sentinels (the app treats them 
as 'use the global default for this category'); positive IDs 
reference `ListOfModels.ModelID` directly.

Source files implementing the dispatch (per cross-ref.md):

- `frmSelectEasyModel.cs`, `frmModelsToBeRun.cs` — model picker UI
- `frmMDAddRelModel.cs`, `frmMDAddExpModel.cs` — add-model dialogs
- `RelModels.cs`, `ExpModels.cs` — per-model calculation routines
- `DBFuncs.cs` — DB queries that pull the activity/model rows

## How to read this

Two layers of model-selection data exist:

1. **Operation-level constraints** (this file): comes from
   `ChmSteer.epa::ListOfValidActivities` (only 4 rows — constrains the
   GS-only operations 103/104 and a few model-picker contexts). For the
   user-defined operations (1=Manufacturing, 2=Processing, 3=Use, 100, 101,
   102), the user picks any activity from the full 72-row
   `ListOfActivities` set at runtime — that's why those sections show
   "_no activities allowed for this operation type — handled at runtime_".
2. **Per-Generic-Scenario activity attachment**: lives in
   `scenarios.epa::Activities` (159 rows) joined to `ActRelModels` /
   `ActExpModels` for the model-per-activity attachment, and is rendered
   per-scenario in `mdb/scenarios.md`.

Both layers ultimately bottom out in the same model registry
(`ChmSteer.epa::ListOfModels`, with the equation as plain text in the
`Equation` column).

## By operation

### Operation 1: User-defined Manufacturing  (type `M`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 2: User-defined Processing  (type `P`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 3: User-defined Use  (type `U`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 100: Automobile OEM Spray Coating  (type `U`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 101: Automobile Refinish Spray Coating  (type `U`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 102: Adhesives Formulation Operation  (type `U`)

_(no activities allowed for this operation type — handled at runtime)_

### Operation 103: Recirculating Water-Cooling Tower Additive Use Operation  (type `U`)

- **Activity 93**: Recirculating Water-Cooling Tower Additive Releases
    - Default release model: `#12` → EPA/OPPT Cooling Tower Blowdown Loss Model 
    - Default release model 2: `#13` → EPA/OPPT Cooling Tower Windage Loss Model 
    - Default release model 3: `#-14` → EPA/OPPT Cooling Tower Evaporative Loss Model (volatiles) (global)

### Operation 104: Electroplating Bath Additive  (type `U`)

- **Activity 94**: Changing Electroplating Bath
    - Default release model: `#51` → EPA/OPPT Electroplating Spent Bath Disposal Model 
    - Valid model options (1):
      - #51 (R) EPA/OPPT Electroplating Spent Bath Disposal Model
- **Activity 95**: Rinsing Electroplated Parts
    - Default release model: `#52` → EPA/OPPT Electroplating Rinse Water Loss Model 
    - Valid model options (1):
      - #52 (R) EPA/OPPT Electroplating Rinse Water Loss Model
- **Activity 96**: Operating Electroplating Bath
    - Default inhalation model: `#23` → OSHA PEL-Limiting Model for Substance-specific Particulates (TWA or C) 
    - Valid model options (1):
      - #39 (R) User-Defined Loss Rate Model
