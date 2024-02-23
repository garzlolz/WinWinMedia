## 定贏面試題目

## 題目一必要條件
### 1. 修改 appsettings.json 中的連線字串

修改 appsettings.json 中的連線字串

- 位置 `WinWinMedia/WinWinMedia_Quiz1/appsettings.json`

```
  "ConnectionStrings": {
    "WitsXMxic": "Server={Your DB Host};TrustServerCertificate=True;Database=WinWin;User ID={Acccount Id};Password={Account Password};"
  }
```

### 2. 加入 DB 結構

1. 執行 WitsXMxic.sql，位置 ` Project/winwin.sql`

2. 或使用 Code First 指令

```
Nuget> Update-Dabase
```

(1 或 2 則一使用)

### 3. 於 VS 中執行


## 第一題圖片
- Swagger
  ![alt text](https://i.imgur.com/4kopdt0.png)

- 取得使用者列表
  ![alt text](https://i.imgur.com/MIqDQsT.png)

- 取得所有地區男女人數
  ![alt text](https://i.imgur.com/cq7bucJ.png)

- 取得省份以及地區
  ![alt text](https://i.imgur.com/6sfqcLa.png)
  
- 創建用戶
  ![alt text](https://i.imgur.com/comLznW.png)