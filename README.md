## MỘT HỆ QUẢN TRỊ CSDL QUAN HỆ CHO CÁC THUỘC TÍNH CÓ GIÁ TRỊ KHOẢNG XÁC SUẤT
### Tình hình nghiên cứu hiện tại
Mô hình cơ sở dữ liệu quan hệ (CSDL QH) truyền thống, được đề xuất bởi E.F. Codd năm 1970, đã chứng minh được hiệu quả trong việc mô hình hóa, thiết kế và triển khai các hệ thống thông tin lớn. Tuy nhiên, hạn chế lớn của mô hình này là chỉ xử lý được dữ liệu chắc chắn – tức dữ liệu phải xác định, chính xác và đầy đủ.
Trong thực tế, thông tin thu thập được thường mang tính không chắc chắn, không đầy đủ hoặc mơ hồ, ví dụ như:
•	Xác suất bệnh nhân bị viêm gan trong khoảng 80–90%;
•	Xác suất gói hàng đến đúng hạn là trên 90%;
•	Khả năng một người phù hợp với một điều kiện nào đó trong khoảng xác suất nhất định.
Các mô hình CSDL truyền thống, kể cả khi mở rộng với giá trị NULL, không thể biểu diễn và xử lý được các loại thông tin này một cách chính xác và đầy đủ.
Để khắc phục, nhiều hướng nghiên cứu đã được đề xuất trên thế giới:
•	Mô hình sử dụng giá trị NULL (như của Imielinski & Lipski) để biểu diễn thông tin chưa biết, nhưng không thể phản ánh được mức độ tin cậy.
•	Mô hình xác suất mức bộ (tuple-level): Mỗi bộ dữ liệu được gán một giá trị xác suất, thể hiện độ tin cậy của toàn bộ bản ghi (ví dụ: Dey & Sarkar, Barbara et al.). Tuy nhiên, không chi tiết đến từng thuộc tính.
•	Mô hình xác suất mức thuộc tính (attribute-level): Mỗi giá trị thuộc tính được gán một xác suất duy nhất, nhưng không phản ánh được sự dao động hoặc không rõ ràng trong xác suất đó.
•	Mô hình khoảng xác suất (interval-based): Các giá trị thuộc tính được kết hợp với một khoảng xác suất [l, u], cho phép biểu diễn cả sự không chắc chắn về giá trị và về mức độ tin cậy. Hướng tiếp cận này mềm dẻo hơn, gần với thực tiễn, và được thể hiện trong các nghiên cứu gần đây như [19], [23].
Tuy nhiên, phần lớn các nghiên cứu nêu trên chỉ tập trung vào xây dựng mô hình lý thuyết mà chưa có hệ quản trị CSDL cụ thể và hiệu quả để triển khai, đặc biệt trong môi trường ứng dụng thực tế.
