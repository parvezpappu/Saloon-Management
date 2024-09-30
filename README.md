# Salon Management System
# Introduction
The Salon Management System is a desktop-based application built using C# and Windows Forms. It simplifies salon operations by providing features for managing services, customer carts, and transaction records. The system offers role-based access for admins and barbers, making it easy for admins to manage salon services and barbers to manage customer transactions.

This project aims to streamline salon operations, improve efficiency, and enhance the overall customer experience by digitizing service management and transaction processes.

# Project Team
- Md Parvej Mia (ID: 22-49155-3)
- Abdulla Al Ehsan (ID: 22-48991-3)
- Saonty Saha (ID: 22-49206-3)
# Faculty:
- MD HASIBUL HASAN 

Assistant Professor, Computer Science

American International University-Bangladesh

# Features
1. User Roles:
    
    + Admin: Manages services, including adding, updating, and deleting salon packages.
    + Barber: Manages customer carts, confirms services, and records transactions.

2. Service Package Management:
    
    - Admin users can create, update, and delete service packages, including setting package names, prices, discounts, and durations.

3. Cart System:

    - Barbers can add services to a customer’s cart, confirm services, and finalize transactions, which are then moved to a record system.

4. Transaction Record:

    - Barbers can view, manage, and clear transaction records for individual customers, making it easy to track customer services.

5. History Clearing:
    
    - The system allows barbers to clear service histories, resetting records for new transactions.

  6. Error Handling:

     - Comprehensive error messages ensure users are informed about incorrect inputs, missing data, and operational issues.

# Technologies Used

- C#
- Microsoft SQL Server
- Windows Forms
- SQL Server Management Studio (SSMS)

# Challenges Faced

1. Database Synchronization:
    - Syncing data between the cart and records required well-structured SQL queries and reliable error handling.
  
2. Role Management:
    - Implementing role-based functionality required careful design to ensure only admins could manage services, while barbers had access to customer-related functions.
  
3. Error Handling:
    - Implementing meaningful error messages for scenarios such as duplicate entries in the cart, failed updates, and database connection issues was crucial for system stability.

  # video
  https://github.com/user-attachments/assets/1ae90283-7140-4735-bd27-c2b75cd292d3

# Learning Throughout the Project

- During the development of the Salon Management System, our team learned:

- Windows Forms Development: We gained hands-on experience building intuitive desktop applications using C# and Windows Forms, focusing on UI design and event handling.

- SQL Server Integration: We learned to design and manage databases with Microsoft SQL Server, handling CRUD operations and efficient data management.

- Role-Based Access Control: Implementing Admin and Barber roles taught us how to manage user permissions and ensure secure access to features.

- Error Handling: We improved our skills in debugging and implementing meaningful error messages, ensuring a smoother user experience.

- Team Collaboration: This project enhanced our teamwork, communication, and version control skills, ensuring seamless integration of tasks.

- Database Optimization: We explored query optimization techniques to ensure faster, more efficient data retrieval and system performance.

- Project Management: We learned to manage time, tasks, and resources effectively, ensuring the project stayed on track from start to finish.

 #  What’s Next
 
 We plan to expand the Salon Management System by:
 
   - Additional Features: Introducing appointment scheduling, customer feedback, and payment gateway integration for a complete, modern solution

   - Mobile App Development: Building a mobile app to allow salon owners, barbers, and customers to access the system on-the-go, enabling real-time updates and remote service management.

   - Cloud Integration: Moving to a cloud-based infrastructure for scalability, data synchronization, and remote access.


