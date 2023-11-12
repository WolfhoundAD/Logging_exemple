import logging

def divide(a, b):
    try:
        result = a / b
        return result
    except ZeroDivisionError as e:
        logging.error("Деление на ноль: %s", e)
        raise

def main():
    logging.basicConfig(filename='log.txt', level=logging.ERROR, format='%(asctime)s - %(levelname)s - %(message)s')

    a = 10
    b = 0

    try:
        result = divide(a, b)
        print("Результат деления:", result)
    except Exception as e:
        logging.exception("Произошла ошибка: %s", e)
        print("Ошибка при выполнении операции.")

if __name__ == '__main__':
    main()