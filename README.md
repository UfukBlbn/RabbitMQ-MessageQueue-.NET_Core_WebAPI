
# RabbitMQ

- Rabbit MQ is the message broker that acts as a middleware while using multiple microservices.

- RabbitMQ is used to reduce the load and delivery time of a web application when some of the resources have taken a lot of time to process the data.


## Project Operation

![Uygulama Ekran Görüntüsü]( https://i.imgur.com/GzNKKPy.png)

- As you can see in the diagram above, there is many producer who sends a message to the RabbitMQ server. The server will store that message inside the queue in a FIFO manner
- Once the producer has sent the message to the queue, there may be multiple consumers that want the message produced by the producer. In that case, consumers subscribe to the message and get that message from the Message Queue as you see in the above diagram.
- In this project, I created a scenario for the situation that I just mentioned.

`Progress`
- A selection is made according to the type among the mail templates saved in the database beforehand. In addition, the type of customer to which the mail will be sent is also selected. 
- And the necessary queue is created for process tracking.

`Error Handling with RabbitMQ`
- In this case, there may be a chance of some technical issue occurring in the mail service. If the user did not receive the e-mail due to this, the user will be impacted and connected with the support team to try to learn the status of the order (it can be a different situation).
- In these scenarios, the RabbitMQ plays an essential role to process messages in the message queue. So, when the consumer gets online, he will receive that email  from the message queue, produced by the producer without impacting the web application.
# RabbitMQ Benefits

`Hight Availability`

- When multiple microservices are used by the application, if one of the microservices is stopped due to technical reasons at that time, the message will never be lost. Instead, it persists in the RabbitMQ server. After some time, when our service starts working, it will connect with RabbitMQ and take the pending message easily.

`Scalability`

- When we use RabbitMQ, at that time our application does not depend on only one server and virtual machine to process a request. If our server is stopped at that time, RabbitMQ will transfer our application load to another server that has the same services running in the background.

## Using Technologies

**Technologies:** .NET 6 / RabbitMQ / Docker

![Logo](https://mennankose.com/content/images/2019/08/asp-net-core-logo-1.png)

![Logo](https://placona.co.uk/images/2012/07/RabbitMQLogo.png)

![Logo](https://blog.knoldus.com/wp-content/uploads/2017/12/docker_facebook_share.png)



    
## Project Images


- Swagger UI 
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/swagger_u%C4%B1.png)

- Docker Desktop (Running)
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/dockerdesk.png)

- RabbitMQ UI
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/rabbit_u%C4%B1.png)

- RabbitMQ Queue UI
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/queue_email.png)

- Listener Result (Console App)
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/consoleapp.png)

- Listener Result (Array Format)
- 
![Uygulama Ekran Görüntüsü](https://raw.githubusercontent.com/UfukBlbn/RabbitMQ-MessageQueue-.NET_Core_WebAPI/main/ProjectImages/listener_array.png)
