# Assignment 2: Manual 3D Scene Generation Report

## 1. Recorded Metrics

The following metrics were recorded during the manual development of the Acoustic Stealth Prototype in Unity.

| Metric | Value |
| :--- | :--- |
| **Total Development Time** | ~45 Minutes |
| **Development Iterations** | 1 |
| **Requirements Mismatched** | 0 |

---

## 2. Methodology & Reflection

### Challenges Encountered
* **Physics Precision:** Transitioning from model-based logic to Unity’s native physics engine required manual tuning of `OnCollisionEnter` thresholds. Ensuring the bottle only triggered the drone on high-velocity impacts (shattering) rather than minor contact was the primary technical hurdle.
* **Manual Logic Wiring:** Without the automated state-machine generation of VReqDV, all object references (linking the Bottle to the Drone, and the Panel to the Door) had to be manually assigned via the Inspector to prevent NullReferenceExceptions.

### Approach Reflection
* **Ease of Use:** Utilizing standard Unity C# hooks like `OnMouseDown` felt significantly more intuitive for spatial interactions than defining JSON schemas.
* **Workflow Clarity:** The direct event-driven workflow (Trigger -> Script -> Action) provided immediate transparency, making it easier to trace logic compared to abstracted dictionary-based systems.
* **Confidence & Experience:** Confidence in the solution's correctness is high due to real-time console debugging. While VReqDV enforces a strict architectural structure, manual development offers the agility needed for rapid physics-based prototyping.
* **Visual completion:** The system being a prototype had a shortcoming of not having polished textures and meshes, to be able to simulate dark lighting and shadows. These changes were however simple enough to transcend into a more rigorous implementation of the system (not a prototpye) where effects can be applied to render light in a dimming environment. 

---

## 3. Requirements Specification


## Project Overview
We need a functional 3D prototype of a single stealth corridor to demonstrate our core "acoustic distraction" gameplay loop. The player’s objective is to safely bypass a security system and unlock the exit without being caught. The scene must be contained within a dark, enclosed hallway.

## Environment & Entities
The corridor features a heavy Vault Door at the far end, which serves as the exit. Beside this door is a wall-mounted Control Panel. The hallway is actively guarded by an automated Security Drone that hovers near the exit. To provide the player with a means of interaction, there must be at least one loose Glass Bottle resting on a crate near the player's starting position.

## Player Interaction & Gameplay Flow
The player must be able to physically interact with the Glass Bottle using the primary input system and throw it down the hallway. When the bottle impacts the environment, it should act as a sound decoy. 

The Security Drone must have two distinct behaviors. By default, it operates in an "Idle" mode, facing the Vault Door and Control Panel. However, if the player throws the Glass Bottle, the Drone must immediately detect the impact and switch to an "Investigating" mode, turning away from the door to face the source of the noise. 

The player must physically trigger the button on the Control Panel to progress, but the system must enforce a strict security rule: The Vault Door will only transition from "Closed" to "Open" if the player triggers the panel button *while* the Security Drone is actively in its "Investigating" mode. If the player attempts to trigger the button while the Drone is still in its default "Idle" mode, the Vault Door must enter a "Permanently Locked" state, resulting in a failed stealth attempt.

---

## 4. Project Export

**Unity Package Google Drive Link:** https://drive.google.com/file/d/1XlcUNpj4yW4lYLzmEQ9oD_pS9Cc7Vv0v/view?usp=sharing
