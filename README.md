gRPC is used for synchronous communication between microservices

For example:

You have an order service and a stock service.

The order service wants to tell the stock service: “3 items were sold.”

gRPC sends this message very quickly and with less data.

Why use gRPC?

It’s faster than normal APIs (because it uses binary data, not JSON).

It’s more efficient — it sends smaller messages.

It’s good for microservices that need to talk to each other often.
