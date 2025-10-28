# RabbitMQ and gRPC Basics

## gRPC

gRPC is used for services to talk to each other **fast and easy**.

Example:  
- You have an **order service** and a **stock service**.  
- The order service says: “3 items were sold.”  
- gRPC sends this message **quickly** and **with less data**.

**Why use gRPC?**  
1. **Fast** – uses binary data, not JSON.  
2. **Efficient** – sends smaller messages.  
3. **Good for microservices** that talk to each other often.  

gRPC is often used for **synchronous communication** between microservices.
