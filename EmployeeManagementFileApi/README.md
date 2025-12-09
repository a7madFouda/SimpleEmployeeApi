
```markdown
# 🚀 Employee Management API

A simple ASP.NET Core Minimal API for managing employee records using a JSON file.

---

## 📋 Features
- ✅ Add employees via POST endpoint
- ✅ Retrieve all employees via GET endpoint
- ✅ Data stored in local `employees.json` file
- ✅ No database required

---

## 🛠️ How to Run

### Step 1: Navigate to the project folder
```bash
cd EmployeeApi
```

### Step 2: Run the application
```bash
dotnet run
```

### Step 3: Note the URL
The API will start at **`http://localhost:7173`** (or check the terminal output for the exact port)

---

## 📡 API Endpoints

### 1️⃣ POST /api/employees
Add a new employee to the system.

**Endpoint:** `POST http://localhost:7173/api/employees`

**Request Body:**
```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "phone": "123-456-7890",
  "department": "IT"
}
```

**Response:** `201 Created`

---

### 2️⃣ GET /api/employees
Retrieve all employees.

**Endpoint:** `GET http://localhost:7173/api/employees`

**Response:** `200 OK`
```json
[
  {
    "name": "John Doe",
    "email": "john@example.com",
    "phone": "123-456-7890",
    "department": "IT"
  },
  {
    "name": "Jane Smith",
    "email": "jane@example.com",
    "phone": "555-1234",
    "department": "HR"
  }
]
```

---

## 🧪 Testing with Postman

### ✅ Test 1: Add an Employee (POST)

1. **Open Postman** and create a new request
2. **Set method to:** `POST`
3. **Enter URL:** `http://localhost:7173/api/employees`
4. **Go to the Body tab**
5. **Select:** `raw` and choose `JSON` from the dropdown
6. **Paste this JSON:**
   ```json
   {
     "name": "Alice Johnson",
     "email": "alice@example.com",
     "phone": "555-9876",
     "department": "Engineering"
   }
   ```
7. **Click Send**
8. **Expected Response:** `201 Created` with the employee data

### ✅ Test 2: Get All Employees (GET)

1. **Create a new request in Postman**
2. **Set method to:** `GET`
3. **Enter URL:** `http://localhost:7173/api/employees`
4. **Click Send**
5. **Expected Response:** `200 OK` with a list of all employees

### 💡 Pro Tip: Add Multiple Employees
Repeat Test 1 with different employee data to build your employee list:

```json
{
  "name": "Bob Williams",
  "email": "bob@example.com",
  "phone": "555-4321",
  "department": "Marketing"
}
```

```json
{
  "name": "Ah",
  "email": "carol@example.com",
  "phone": "555-8765",
  "department": "Finance"
}
```

---

## 🧪 Testing with cURL (Alternative)

### Add an employee:
```bash
curl -X POST http://localhost:7173/api/employees \
  -H "Content-Type: application/json" \
  -d '{"name":"Jane Smith","email":"jane@example.com","phone":"555-1234","department":"HR"}'
```

### Get all employees:
```bash
curl http://localhost:7173/api/employees
```

---

## 📁 File Created
- **`employees.json`** - Created automatically in the project root directory when you add the first employee. This file stores all employee records in JSON format.

---

## 💻 Requirements
- .NET 6.0 or higher
- Postman (optional, for testing)

---

## 🎯 Quick Troubleshooting

| Issue | Solution |
|-------|----------|
| **Port already in use** | Check terminal output for actual port, or change it in `launchSettings.json` |
| **404 Not Found** | Make sure the API is running (`dotnet run`) |
| **Empty response on GET** | Add employees first using POST endpoint |
| **File not created** | File is created only after first successful POST request |

---

## 📝 Notes
- The `employees.json` file is created in the same folder as your project
- Each POST request appends a new employee to the file
- The API keeps the data in a simple, readable JSON format

---