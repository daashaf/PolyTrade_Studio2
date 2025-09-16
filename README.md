# PolyTrade — Studio 2 (Windows Forms + Text File)

** A simple **C# Windows Forms** desktop app where students browse items by **Stationery, Snacks, Clothing, Footwear**.  
**Where data lives:** a single **`items.txt`** file.  
**Goal:** make it easy to demo the flow: **open → pick a category → see items**.

---

## TL;DR for the marker
- ✅ Windows desktop app (C# WinForms)  
- ✅ Four categories (Stationery, Snacks, Clothing, Footwear)  
- ✅ Items loaded from **`items.txt`**  
- ✅ Clean, simple navigation via buttons

---

## Quick Start
1. Open `PolyTrade_WebApp.sln` in **Visual Studio 2019/2022** (with **.NET Desktop Development**).
2. Set the WinForms project as **Startup Project**.
3. Press **F5** to build and run.

---

## Data: `items.txt` format
Each line = one item in CSV-style:
```
<Category>,<ItemName>,<PriceOrNote>
Stationery,Blue Pen,$2
Snacks,Chocolate Bar,$3
Clothing,Poly Hoodie,$35
Footwear,Sports Shoes,$60
```
**Rules**
- Category must be exactly: `Stationery`, `Snacks`, `Clothing`, `Footwear`.
- Keep commas out of names/notes unless your parser handles quotes.
- Place `items.txt` where the code expects it (e.g., app root or `./data/items.txt`).

---

## Using the App
- **Dashboard → Category**: click a button to open a category form.  
- **Browse items**: items for that category are shown from `items.txt`.  
- **Back/Exit**: use the provided buttons (per your build).

---

## Project Structure (example)
```
PolyTrade/
├─ PolyTrade_WebApp.sln
├─ PolyTrade_WebApp/
│  ├─ Program.cs
│  ├─ Dashboard.cs / Dashboard.Designer.cs
│  ├─ Stationery.cs / Stationery.Designer.cs
│  ├─ Snacks.cs / Snacks.Designer.cs
│  ├─ Clothing.cs / Clothing.Designer.cs
│  ├─ Footwear.cs / Footwear.Designer.cs
│  ├─ Properties/
│  └─ Resources/           
├
│             
└─ README.md
```

---

## Common Gotchas
- **Blank list?** Missing/empty `items.txt`, wrong path, or category names don’t match.  
- **Crash on load?** Malformed line in `items.txt` (e.g., extra commas).  
- **Wrong screen names?** Double‑check class/file names and spelling (e.g., `Dashboard`, not `Dashbaord`; `Stationery`, not `Stationary`).

---

## Quality Checklist
- [ ] Builds & runs via **F5**  
- [ ] Buttons open each category form  
- [ ] Items load correctly from `items.txt`  
- [ ] Spelling & case match labels/class names  
- [ ] No unhandled exceptions

---

## Team 
- **Daasha** 
- **Aviyash** 
- **Vraj** 
- **Viren**

---

## Version
**Studio 2 — Windows Forms + Text File (Desktop)**
